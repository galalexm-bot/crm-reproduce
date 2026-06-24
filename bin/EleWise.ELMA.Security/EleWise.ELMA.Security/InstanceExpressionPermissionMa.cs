using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component(Order = 10)]
public class InstanceExpressionPermissionManagerBehavior : EntityManagerBehavior
{
	private readonly IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions;

	private readonly IPermissionManagmentService permissionManagmentService;

	private readonly IAuthenticationService authenticationService;

	private readonly ISecurityService securityService;

	internal static InstanceExpressionPermissionManagerBehavior ncYXKd7HhyWVJOuTHx8;

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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public InstanceExpressionPermissionManagerBehavior(IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions, IPermissionManagmentService permissionManagmentService, IAuthenticationService authenticationService, ISecurityService securityService)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.instanceExpressionPermissions = instanceExpressionPermissions;
		this.permissionManagmentService = permissionManagmentService;
		this.authenticationService = authenticationService;
		this.securityService = securityService;
	}

	public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_007d, IL_008d, IL_009c, IL_00d3, IL_011d, IL_014f, IL_0166, IL_0296, IL_02a5, IL_02b5, IL_02f1
		int num = 6;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		Permission permission = default(Permission);
		Guid? permissionId = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 13:
					return;
				case 16:
					if (filter == null)
					{
						num2 = 14;
						break;
					}
					goto case 4;
				case 8:
				case 14:
					obj = UeUSLG7PybldWIvhfsk(permissionManagmentService, CommonPermissions.View, _003C_003Ec__DisplayClass9_.criteriaRootType);
					goto IL_0325;
				case 9:
					if (WQKFXS7CiUDHPmhCnR4(permission, null))
					{
						num2 = 2;
						break;
					}
					_003C_003Ec__DisplayClass9_.user = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
					{
						num2 = 18;
					}
					break;
				default:
					try
					{
						_003C_003Ec__DisplayClass9_.criteriaRootType = e012MN72qr5OuQLsUyD(_003C_003Ec__DisplayClass9_.criteria);
						int num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
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
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					goto case 16;
				case 18:
					if (_003C_003Ec__DisplayClass9_.user != null)
					{
						num2 = 22;
						break;
					}
					goto case 3;
				case 15:
					return;
				case 21:
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
					num2 = 5;
					break;
				case 3:
					throw new InvalidOperationException(SR.T((string)SmfLbw7URLVXxYmpN6b(-1084772212 ^ -1084778224)));
				case 22:
					if (!HasAdminPermissions(permission, _003C_003Ec__DisplayClass9_.user))
					{
						goto end_IL_0012;
					}
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 != 0)
					{
						num2 = 1;
					}
					break;
				case 19:
					if (!filter.DisableSecurity)
					{
						num2 = 7;
						break;
					}
					return;
				case 4:
					permissionId = filter.PermissionId;
					num2 = 12;
					break;
				case 12:
				{
					if (!permissionId.HasValue)
					{
						num2 = 8;
						break;
					}
					IPermissionManagmentService obj2 = permissionManagmentService;
					permissionId = filter.PermissionId;
					obj = njp63k7vev5JBjeXdOr(obj2, permissionId.Value);
					goto IL_0325;
				}
				case 17:
					return;
				case 7:
				case 11:
					if (nBd7aX7wUDkXHDH0NBS(RunWithElevatedPrivilegiesService))
					{
						return;
					}
					num2 = 21;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_147eeadb328044dda63bf8b1037653db != 0)
					{
						num2 = 11;
					}
					break;
				case 2:
					return;
				case 5:
					_003C_003Ec__DisplayClass9_.criteria = criteria;
					num2 = 20;
					break;
				case 1:
					return;
				case 20:
					if (filter == null)
					{
						num2 = 11;
						break;
					}
					goto case 19;
				case 10:
					{
						(from p in instanceExpressionPermissions.Where(_003C_003Ec__DisplayClass9_._003COnCreateCriteria_003Eb__0)
							group p by (string)_003C_003Ec.Yk1rVypiJDc8ZyOpTCkl(p)).ForEach(_003C_003Ec__DisplayClass9_._003COnCreateCriteria_003Eb__2);
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
						{
							num2 = 13;
						}
						break;
					}
					IL_0325:
					permission = (Permission)obj;
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 9;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass9_.transform = Locator.GetServiceNotNull<ITransformationProvider>();
			num = 10;
		}
	}

	private bool HasAdminPermissions(Permission permission, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0039, IL_0049, IL_00e9, IL_00f8, IL_0107, IL_0138, IL_0157, IL_0166, IL_0193, IL_01a2
		int num = 4;
		int num2 = num;
		IEnumerator<Permission> enumerator = default(IEnumerator<Permission>);
		bool result = default(bool);
		Permission current = default(Permission);
		Permission[] array = default(Permission[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!dcFUMT7KVa0rSUoC12c(enumerator))
						{
							num3 = 5;
							goto IL_0057;
						}
						goto IL_00d1;
						IL_0057:
						while (true)
						{
							switch (num3)
							{
							case 1:
								result = true;
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								if (!Lqon9u7JFp6VyHWx1xp(securityService, user, current))
								{
									int num4 = 3;
									num3 = num4;
									continue;
								}
								goto case 1;
							case 3:
							case 6:
								break;
							case 2:
								goto IL_00d1;
							case 5:
								goto end_IL_00bb;
							default:
								return result;
							case 0:
								return result;
							}
							break;
						}
						continue;
						IL_00d1:
						current = enumerator.Current;
						num3 = 4;
						goto IL_0057;
						continue;
						end_IL_00bb:
						break;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
						{
							num5 = 0;
						}
						goto IL_013c;
					}
					goto IL_0171;
					IL_0171:
					a3CKMH7tdvpYaEa9e0b(enumerator);
					num5 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
					{
						num5 = 1;
					}
					goto IL_013c;
					IL_013c:
					switch (num5)
					{
					default:
						goto end_IL_0117;
					case 0:
						goto end_IL_0117;
					case 2:
						break;
					case 1:
						goto end_IL_0117;
					}
					goto IL_0171;
					end_IL_0117:;
				}
				goto default;
			case 3:
				if (array == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				return false;
			case 4:
				array = (Permission[])KkoscY7ojSr1ILVKJvA(permission);
				num2 = 3;
				continue;
			case 5:
				break;
			}
			enumerator = array.Where((Permission p) => _003C_003Ec.zPxbcTpiK7lSa0uXnTEY(p) == PermissionType.Global).GetEnumerator();
			num2 = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static bool pdcguH7acIABFtM10FH()
	{
		return ncYXKd7HhyWVJOuTHx8 == null;
	}

	internal static InstanceExpressionPermissionManagerBehavior wnx5C67R5pUCDOscsTT()
	{
		return ncYXKd7HhyWVJOuTHx8;
	}

	internal static bool nBd7aX7wUDkXHDH0NBS(object P_0)
	{
		return ((RunWithElevatedPrivilegiesService)P_0).Turned;
	}

	internal static Type e012MN72qr5OuQLsUyD(object P_0)
	{
		return ((ICriteria)P_0).GetRootEntityTypeIfAvailable();
	}

	internal static object UeUSLG7PybldWIvhfsk(object P_0, object P_1, Type P_2)
	{
		return ((IPermissionManagmentService)P_0).GetPermissionForBase((Permission)P_1, P_2);
	}

	internal static object njp63k7vev5JBjeXdOr(object P_0, Guid P_1)
	{
		return ((IPermissionManagmentService)P_0).GetPermission(P_1);
	}

	internal static bool WQKFXS7CiUDHPmhCnR4(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static object SmfLbw7URLVXxYmpN6b(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object KkoscY7ojSr1ILVKJvA(object P_0)
	{
		return ((Permission)P_0).AdminPermissions;
	}

	internal static bool Lqon9u7JFp6VyHWx1xp(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2);
	}

	internal static bool dcFUMT7KVa0rSUoC12c(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void a3CKMH7tdvpYaEa9e0b(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
