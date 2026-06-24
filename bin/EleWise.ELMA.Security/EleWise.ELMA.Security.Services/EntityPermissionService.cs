using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Services;

[Service(Scope = ServiceScope.Shell, Type = ComponentType.Server, EnableInterceptors = true)]
internal class EntityPermissionService : IEntityPermissionService
{
	private readonly ISecurityService securityService;

	private readonly IEnumerable<IInstanceSettingsPermission> instanceSettingsPermissions;

	private readonly IPermissionManagmentService permissionManagmentService;

	private readonly IEnumerable<IRoleTypeSelectorGroupsCategory> roleTypeSelectorGroupsCategories;

	private readonly IPermissionTypeRoleService permissionTypeRoleService;

	private readonly UserManager userManager;

	private static EntityPermissionService krbmMQRVEc7JI9gmwZE;

	public EntityPermissionService(ISecurityService securityService, IEnumerable<IInstanceSettingsPermission> instanceSettingsPermissions, IPermissionManagmentService permissionManagmentService, IEnumerable<IRoleTypeSelectorGroupsCategory> roleTypeSelectorGroupsCategories, IPermissionTypeRoleService permissionTypeRoleService, UserManager userManager)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.securityService = securityService;
		this.instanceSettingsPermissions = instanceSettingsPermissions;
		this.permissionManagmentService = permissionManagmentService;
		this.roleTypeSelectorGroupsCategories = roleTypeSelectorGroupsCategories;
		this.permissionTypeRoleService = permissionTypeRoleService;
		this.userManager = userManager;
	}

	public bool CheckIfPermissionNeededForEntity(long[] objectsIds, Type type, long[] usersIds, string[] prefixedUsersIds, Guid permission, bool needReplacement = false)
	{
		//Discarded unreachable code: IL_019c, IL_01d4
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0;
		bool result = default(bool);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
					int num3 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 7:
							xd0GdsRg2RDYPndVLCD(securityService, (Action)delegate
							{
								int num6 = 1;
								int num7 = num6;
								while (true)
								{
									switch (num7)
									{
									default:
										return;
									case 1:
										CS_0024_003C_003E8__locals0.objects = CS_0024_003C_003E8__locals0.entityManager.FindByIdArray(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.objectsIds.Distinct().Cast<object>().ToArray()).Cast<object>().ToList();
										num7 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
										{
											num7 = 0;
										}
										break;
									case 0:
										return;
									}
								}
							});
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
							{
								num3 = 1;
							}
							break;
						case 6:
							CS_0024_003C_003E8__locals0.usersToCheck = FormUsersList(usersIds, prefixedUsersIds, needReplacement);
							num3 = 7;
							break;
						default:
						{
							CS_0024_003C_003E8__locals0.objects = null;
							int num4 = 6;
							num3 = num4;
							break;
						}
						case 4:
							CS_0024_003C_003E8__locals0.entityManager = (IEntityManager)o0XoxjRTLpG2JlOVAQv(type);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							result = q8kLQuR80itg12gY5Yu(CS_0024_003C_003E8__locals0.objects) > 0;
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
							{
								num3 = 2;
							}
							break;
						case 5:
							CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass7_;
							num3 = 4;
							break;
						case 1:
							CS_0024_003C_003E8__locals0.objects = CS_0024_003C_003E8__locals0.objects.Where(delegate(object o)
							{
								int num8 = 2;
								int num9 = num8;
								_003C_003Ec__DisplayClass7_2 _003C_003Ec__DisplayClass7_2 = default(_003C_003Ec__DisplayClass7_2);
								while (true)
								{
									switch (num9)
									{
									case 1:
										_003C_003Ec__DisplayClass7_2.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
										num9 = 3;
										break;
									default:
										return CS_0024_003C_003E8__locals0.usersToCheck.Any(_003C_003Ec__DisplayClass7_2._003CCheckIfPermissionNeededForEntity_003Eb__2);
									case 3:
										_003C_003Ec__DisplayClass7_2.o = o;
										num9 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
										{
											num9 = 0;
										}
										break;
									case 2:
										_003C_003Ec__DisplayClass7_2 = new _003C_003Ec__DisplayClass7_2();
										num9 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 != 0)
										{
											num9 = 1;
										}
										break;
									}
								}
							}).ToList();
							num3 = 3;
							break;
						case 2:
							return result;
						}
					}
				}
				catch (Exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return result;
						}
						result = false;
						num5 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
						{
							num5 = 1;
						}
					}
				}
			case 1:
				_003C_003Ec__DisplayClass7_.objectsIds = objectsIds;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass7_._003C_003E4__this = this;
				num2 = 3;
				break;
			case 3:
				_003C_003Ec__DisplayClass7_.permission = permission;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				return result;
			case 2:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public IEnumerable<string> CheckGrantablePermissions(Type type, string guids, string data)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		Contract.ArgumentNotNull(type, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738E3073 ^ 0x738E637D));
		Contract.ArgumentNotNullOrEmpty(guids, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730092410));
		Contract.ArgumentNotNullOrEmpty(data, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1889123947 ^ -1889135959));
		List<Guid> list = guids.FromJson<Guid[]>().ToList();
		IdAndTypeRole idAndTypeRole = data.FromJson<IdAndTypeRole>();
		object obj = EntityHelper.GetEntityManager(type).Load(idAndTypeRole.EntityId).CastAs<object>();
		IInstanceSettingsPermission settingsPermission = GetSettingsPermission(obj);
		CS_0024_003C_003E8__locals0.grantablePermissions = settingsPermission.CanGrandLevel(AuthenticationService.GetCurrentUser(), obj);
		if (CS_0024_003C_003E8__locals0.grantablePermissions == null)
		{
			return new List<string>();
		}
		list.RemoveAll((Guid i) => CS_0024_003C_003E8__locals0.grantablePermissions.Select((Permission x) => _003C_003Ec.t6euQVpZCjcTsXeqLL2d(x)).Contains(i));
		return list.Select((Guid x) => ((Permission)_003C_003Ec__DisplayClass8_0.iPE00WpZReYxAnU4c3VP(CS_0024_003C_003E8__locals0._003C_003E4__this.permissionManagmentService, x)).Name);
	}

	public AddPermissionModel EntityAddPermission(long[] id, Type type, long[] usersIds, string[] prefixedUsersIds, Guid permission, Guid[] defaultPermissions = null, bool needReplacement = false)
	{
		int num = 3;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		AddPermissionModel addPermissionModel = default(AddPermissionModel);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass9_.id = id;
					num2 = 13;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
					{
						num2 = 21;
					}
					continue;
				case 9:
					break;
				case 8:
					_003C_003Ec__DisplayClass9_.objects.ForEach(_003C_003Ec__DisplayClass9_._003CEntityAddPermission_003Eb__2);
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass9_.hasGrantPermission = true;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					_003C_003Ec__DisplayClass9_.dict = new Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>>();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
					{
						num2 = 1;
					}
					continue;
				case 19:
					addPermissionModel = new AddPermissionModel();
					num2 = 4;
					continue;
				case 6:
					XLe5h4RyT5hDw0f1Ij5(addPermissionModel, type);
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
					xd0GdsRg2RDYPndVLCD(securityService, new Action(_003C_003Ec__DisplayClass9_._003CEntityAddPermission_003Eb__0));
					num2 = 14;
					continue;
				case 20:
					_003C_003Ec__DisplayClass9_.permission = permission;
					num2 = 16;
					continue;
				case 3:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					lP59ATR3Sl6Fvpn2474(addPermissionModel, entityMetadata);
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass9_.users = FormUsersList(usersIds, prefixedUsersIds, needReplacement);
					num2 = 9;
					continue;
				case 16:
					_003C_003Ec__DisplayClass9_.entityManager = (IEntityManager)o0XoxjRTLpG2JlOVAQv(type);
					num2 = 12;
					continue;
				case 4:
					addPermissionModel.Dictionary = _003C_003Ec__DisplayClass9_.dict;
					num2 = 11;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					return addPermissionModel;
				case 7:
					entityMetadata = (EntityMetadata)WvC761Rrav304CvsJg4(type, true, true);
					num2 = 19;
					continue;
				case 22:
					addPermissionModel.GrandPermissions = _003C_003Ec__DisplayClass9_.grandPermissions;
					num2 = 15;
					continue;
				case 21:
					_003C_003Ec__DisplayClass9_._003C_003E4__this = this;
					num2 = 20;
					continue;
				case 14:
					_003C_003Ec__DisplayClass9_.objects = _003C_003Ec__DisplayClass9_.objects.Where(_003C_003Ec__DisplayClass9_._003CEntityAddPermission_003Eb__1).ToList();
					num2 = 5;
					continue;
				default:
					_003C_003Ec__DisplayClass9_.grandPermissions = new Dictionary<long, IEnumerable<Permission>>();
					num2 = 8;
					continue;
				case 17:
					addPermissionModel.HasGrantPermission = _003C_003Ec__DisplayClass9_.hasGrantPermission;
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 != 0)
					{
						num2 = 22;
					}
					continue;
				case 10:
					addPermissionModel.PermissionTypeRolesModels = GetRoleTypeModels(_003C_003Ec__DisplayClass9_.dict, type, defaultPermissions ?? new Guid[1] { _003C_003Ec__DisplayClass9_.permission });
					num2 = 13;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 != 0)
					{
						num2 = 18;
					}
					continue;
				case 18:
					T3y0rTRbLy82eQOk1Tl(addPermissionModel, defaultPermissions ?? new Guid[1] { _003C_003Ec__DisplayClass9_.permission });
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass9_.objects = null;
			num = 13;
		}
	}

	public bool EntityAddPermissionSave(long[] id, Type type, EditableListModel accessBindList)
	{
		//Discarded unreachable code: IL_0063, IL_0076, IL_0085
		int num = 10;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass10_.type = type;
					num2 = 6;
					break;
				case 9:
					_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
					num2 = 4;
					break;
				case 6:
					if (id == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					return true;
				case 4:
					_003C_003Ec__DisplayClass10_.accessBindList = accessBindList;
					num2 = 5;
					break;
				case 7:
					return true;
				case 3:
					if (bnk4deRSLAOhGEbNoCM(_003C_003Ec__DisplayClass10_.type, null))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 8:
					_003C_003Ec__DisplayClass10_.entityManager.FindByIdArray(id.Distinct().Cast<object>().ToArray()).Cast<object>().ToList()
						.ForEach(_003C_003Ec__DisplayClass10_._003CEntityAddPermissionSave_003Eb__0);
					num2 = 7;
					break;
				case 2:
					if (_003C_003Ec__DisplayClass10_.accessBindList != null)
					{
						_003C_003Ec__DisplayClass10_.entityManager = (IEntityManager)o0XoxjRTLpG2JlOVAQv(_003C_003Ec__DisplayClass10_.type);
						num2 = 8;
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 1;
					}
					break;
				case 10:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 9;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	private List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>> GetRoleTypeModels(Dictionary<object, List<EleWise.ELMA.Security.Models.IUser>> objects, Type type, Guid[] defaultPermissionUids)
	{
		_003C_003Ec__DisplayClass11_3 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0.permissionRolesStereotype = permissionTypeRoleService.GetPermissionRoles(type);
		CS_0024_003C_003E8__locals0.defaultPermissions = defaultPermissionUids.Select(delegate(Guid defaultPermissionUid)
		{
			int num3 = 1;
			int num4 = num3;
			_003C_003Ec__DisplayClass11_1 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_1);
			while (true)
			{
				switch (num4)
				{
				case 1:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_1();
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
					{
						num4 = 0;
					}
					break;
				default:
					_003C_003Ec__DisplayClass11_.defaultPermissionUid = defaultPermissionUid;
					num4 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
					{
						num4 = 0;
					}
					break;
				case 2:
					return CS_0024_003C_003E8__locals0.permissionRolesStereotype.Select((Tuple<Permission, PermissionRoleType[]> t) => t.Item1).FirstOrDefault(_003C_003Ec__DisplayClass11_._003CGetRoleTypeModels_003Eb__3);
				}
			}
		}).ToList();
		CS_0024_003C_003E8__locals0.items = new List<Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>>();
		objects.ToList().ForEach(delegate(KeyValuePair<object, List<EleWise.ELMA.Security.Models.IUser>> d)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_2();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.d = d;
			CS_0024_003C_003E8__locals0.items.AddRange(CS_0024_003C_003E8__locals0.permissionRolesStereotype.Select(delegate(Tuple<Permission, PermissionRoleType[]> t)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_3();
				CS_0024_003C_003E8__locals0.permission = t.Item1;
				List<EleWise.ELMA.Security.Models.IUser> value = CS_0024_003C_003E8__locals0.d.Value;
				List<AssignedRoleTypeModel> item = ((CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.defaultPermissions.Any((Permission p) => _003C_003Ec__DisplayClass11_3.ehj2yKpxmEg0I70PDBCG(p, CS_0024_003C_003E8__locals0.permission)) || (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.defaultPermissions != null && CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.defaultPermissions.Any(delegate(Permission defaultPermission)
				{
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							return ((IEnumerable<Permission>)_003C_003Ec__DisplayClass11_3.yEYm4xpxeixEZ97EOPZd(defaultPermission)).Contains(CS_0024_003C_003E8__locals0.permission);
						case 1:
							if (defaultPermission.Dependencies == null)
							{
								return false;
							}
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}))) ? value.Select((EleWise.ELMA.Security.Models.IUser u) => new AssignedRoleTypeModel(CommonRoleTypes.User, u)).ToList() : new List<AssignedRoleTypeModel>());
				return new Tuple<Permission, object, IEnumerable<AssignedRoleTypeModel>>(CS_0024_003C_003E8__locals0.permission, CS_0024_003C_003E8__locals0.d.Key, item);
			}).ToList());
		});
		return CS_0024_003C_003E8__locals0.items;
	}

	private IInstanceSettingsPermission GetSettingsPermission(object instance)
	{
		int num = 1;
		int num2 = num;
		IInstanceSettingsPermission instanceSettingsPermission = default(IInstanceSettingsPermission);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (instanceSettingsPermission == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
					{
						num2 = 2;
					}
					break;
				}
				return instanceSettingsPermission;
			default:
				_003C_003Ec__DisplayClass12_.type = EntityHelper.GetType(instance);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				instanceSettingsPermission = instanceSettingsPermissions.FirstOrDefault(_003C_003Ec__DisplayClass12_._003CGetSettingsPermission_003Eb__0);
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				throw new InvalidOperationException((string)wJ20HTR1xvmOjY89ju3(nb2JgER9ywQawl0fASR(0x23D92C6F ^ 0x23D9340F), new object[1] { inVppxRftdAlnAeLE2k(_003C_003Ec__DisplayClass12_.type) }));
			}
		}
	}

	private List<EleWise.ELMA.Security.Models.IUser> FormUsersList(long[] usersIds, string[] prefixedUsersIds, bool needReplacement = false)
	{
		List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
		if (usersIds != null)
		{
			list.AddRange(userManager.FindByIdArray(usersIds));
		}
		if (prefixedUsersIds != null)
		{
			FillUsersByPrefixed(list, prefixedUsersIds);
		}
		if (needReplacement)
		{
			List<EleWise.ELMA.Security.Models.IUser> collection = new List<EleWise.ELMA.Security.Models.IUser>();
			{
				foreach (EleWise.ELMA.Security.Models.IUser item in list)
				{
					if (item.ReplacementUser != null)
					{
						collection.AddIfNotContains(item.ReplacementUser);
					}
				}
				return list;
			}
		}
		return list;
	}

	private void FillUsersByPrefixed(List<EleWise.ELMA.Security.Models.IUser> users, string[] prefixedUserIds)
	{
		for (int i = 0; i < prefixedUserIds.Length; i++)
		{
			using List<EleWise.ELMA.Security.Models.IUser>.Enumerator enumerator = BaseEntityUserTypeSelector.GetUsers(prefixedUserIds[i]).GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
				CS_0024_003C_003E8__locals0.prefixedUser = enumerator.Current;
				if (users.All((EleWise.ELMA.Security.Models.IUser u) => !u.Equals(CS_0024_003C_003E8__locals0.prefixedUser)) && CS_0024_003C_003E8__locals0.prefixedUser.Status == UserStatus.Active)
				{
					users.Add(CS_0024_003C_003E8__locals0.prefixedUser);
				}
			}
		}
	}

	private object GetEntity(EditableListItem i, Type type)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6
		int num = 3;
		int num2 = num;
		long num3 = default(long);
		IEntityManager entityManager = default(IEntityManager);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = lwkjiRRzqDCZO6ElmHN(i.Value.FromJson<IdAndTypeRole>());
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				entityManager = (IEntityManager)o0XoxjRTLpG2JlOVAQv(type);
				num2 = 2;
				break;
			default:
				if (num3 > 0)
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				return null;
			case 4:
				return YcOobkwkd2KDse29Rg5(entityManager, num3);
			}
		}
	}

	private Tuple<IEntity, PermissionRoleType> GetAssignedEntity(EditableListItem i, object instance)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals0.idObjectType = i.Value.FromJson<IdAndTypeRole>();
		PermissionRoleType permissionRoleType = (roleTypeSelectorGroupsCategories.Any((IRoleTypeSelectorGroupsCategory r) => _003C_003Ec__DisplayClass16_0.Ad9AOdpxthCSsLp8Svov(_003C_003Ec__DisplayClass16_0.R9e8O2pxJTYFtoyTc8Ts(r), _003C_003Ec__DisplayClass16_0.a9fCFgpxK8jxyWbsC0mx(CS_0024_003C_003E8__locals0.idObjectType))) ? CommonRoleTypes.Group : permissionTypeRoleService.Load(CS_0024_003C_003E8__locals0.idObjectType.ObjectType));
		IEntity item = null;
		if (permissionRoleType == CommonRoleTypes.Property)
		{
			_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass16_1();
			if (Guid.TryParse(CS_0024_003C_003E8__locals0.idObjectType.Id, out CS_0024_003C_003E8__locals1.pUid))
			{
				EntityMetadata entityMetadata = permissionRoleType.AssignedEntityEvalutor(instance) as EntityMetadata;
				PropertyMetadata propertyMetadata = entityMetadata?.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass16_1.uyFaHBpxGmBTvcQl96Wf(p) == CS_0024_003C_003E8__locals1.pUid);
				item = new PropertyMetadataReference(entityMetadata, propertyMetadata);
			}
		}
		else if (permissionRoleType.AssignedEntityEvalutor != null)
		{
			item = permissionRoleType.AssignedEntityEvalutor(instance);
		}
		else if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.idObjectType.Id))
		{
			Type linkedEntityType = permissionRoleType.LinkedEntityType;
			if (linkedEntityType == null)
			{
				throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71BC7C31 ^ 0x71BC2F6D), permissionRoleType.Name, CS_0024_003C_003E8__locals0.idObjectType.Id));
			}
			item = (IEntity)EntityHelper.GetEntityManager(linkedEntityType).Load(CS_0024_003C_003E8__locals0.idObjectType.Id);
		}
		return new Tuple<IEntity, PermissionRoleType>(item, permissionRoleType);
	}

	internal static object o0XoxjRTLpG2JlOVAQv(Type P_0)
	{
		return EntityHelper.GetEntityManager(P_0);
	}

	internal static void xd0GdsRg2RDYPndVLCD(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static int q8kLQuR80itg12gY5Yu(object P_0)
	{
		return ((List<object>)P_0).Count;
	}

	internal static bool gjKC3CRQMymZaRvKhES()
	{
		return krbmMQRVEc7JI9gmwZE == null;
	}

	internal static EntityPermissionService DN5m15RdRaUpNob6GbS()
	{
		return krbmMQRVEc7JI9gmwZE;
	}

	internal static object WvC761Rrav304CvsJg4(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static void lP59ATR3Sl6Fvpn2474(object P_0, object P_1)
	{
		((AddPermissionModel)P_0).EntityMetadata = (EntityMetadata)P_1;
	}

	internal static void XLe5h4RyT5hDw0f1Ij5(object P_0, Type value)
	{
		((AddPermissionModel)P_0).EntityType = value;
	}

	internal static void T3y0rTRbLy82eQOk1Tl(object P_0, object P_1)
	{
		((AddPermissionModel)P_0).DefaultPermissions = (Guid[])P_1;
	}

	internal static bool bnk4deRSLAOhGEbNoCM(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object nb2JgER9ywQawl0fASR(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object inVppxRftdAlnAeLE2k(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object wJ20HTR1xvmOjY89ju3(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static long lwkjiRRzqDCZO6ElmHN(object P_0)
	{
		return ((IdAndTypeRole)P_0).EntityId;
	}

	internal static object YcOobkwkd2KDse29Rg5(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Load(P_1);
	}
}
