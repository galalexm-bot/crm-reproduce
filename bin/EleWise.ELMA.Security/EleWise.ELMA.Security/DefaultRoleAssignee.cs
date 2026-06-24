using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component(EnableInterceptiors = true)]
public class DefaultRoleAssignee : IModuleEvents, IModuleContainerEvents
{
	private readonly IPermissionManagmentService permissionManagmentService;

	private readonly IEnumerable<IPermissionProvider> permissionProviders;

	private readonly UserGroupManager userGroupManager;

	private readonly GroupPermissionManager groupPermissionManager;

	private readonly IModuleService moduleService;

	private readonly IEntityManager<IAssignedRoleStereotype> assignedRoleStereotypeManager;

	internal static DefaultRoleAssignee b9mmddX5XVupUbc4uVw;

	public DefaultRoleAssignee(IPermissionManagmentService permissionManagmentService, IEnumerable<IPermissionProvider> permissionProviders, UserGroupManager userGroupManager, GroupPermissionManager groupPermissionManager, IModuleService moduleService, IEntityManager<IAssignedRoleStereotype> assignedRoleStereotypeManager)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.permissionManagmentService = permissionManagmentService;
		this.permissionProviders = permissionProviders;
		this.userGroupManager = userGroupManager;
		this.groupPermissionManager = groupPermissionManager;
		this.moduleService = moduleService;
		this.assignedRoleStereotypeManager = assignedRoleStereotypeManager;
	}

	[Transaction]
	public virtual void AssignDefaultRoles()
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00fa, IL_0109, IL_023a, IL_048a, IL_0502, IL_053a, IL_0549, IL_05db, IL_060b, IL_061a, IL_0626, IL_0635
		int num = 2;
		int num2 = num;
		IEnumerator<PermissionStereotype> enumerator = default(IEnumerator<PermissionStereotype>);
		IEnumerator<Permission> enumerator2 = default(IEnumerator<Permission>);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IUserGroup userGroup = default(IUserGroup);
		_003C_003Ec__DisplayClass7_1 _003C_003Ec__DisplayClass7_2 = default(_003C_003Ec__DisplayClass7_1);
		Permission current2 = default(Permission);
		IAssignedRoleStereotype assignedRoleStereotype = default(IAssignedRoleStereotype);
		PermissionStereotype current = default(PermissionStereotype);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_057c:
						int num3;
						if (!mO6l3pXRyNbZWg0rUK8(enumerator))
						{
							num3 = 7;
							goto IL_004c;
						}
						goto IL_0114;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								enumerator2 = _003C_003Ec__DisplayClass7_.stereotype.Permissions.GetEnumerator();
								num3 = 8;
								continue;
							case 9:
							{
								InstanceOf<IUserGroup> instanceOf = new InstanceOf<IUserGroup>();
								RpEuMFXBgQGlqO0wc3J(instanceOf.New, cKKH4kXxtTWHqxKXixU(epkr4NXZlHwUTMvgpRR(_003C_003Ec__DisplayClass7_.stereotype)));
								instanceOf.New.Uid = GsrgifXufF7ikdNBdIs(epkr4NXZlHwUTMvgpRR(_003C_003Ec__DisplayClass7_.stereotype));
								userGroup = instanceOf.New;
								num3 = 5;
								continue;
							}
							case 4:
								break;
							case 10:
								if (_003C_003Ec__DisplayClass7_.stereotype == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto default;
							case 12:
								_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
								num3 = 4;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
								{
									num3 = 6;
								}
								continue;
							default:
							{
								UserGroupManager obj = userGroupManager;
								ParameterExpression parameterExpression = (ParameterExpression)v6XeOhXnePv0lMLklI0(maxGhDXXm5IhkDwA5DD(typeof(IUserGroup).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1518425080 ^ -1518434184));
								userGroup = obj.Find(Expression.Lambda<Func<IUserGroup, bool>>((Expression)hqkRxqXNY72YFkxtsxd(Expression.Property(parameterExpression, (MethodInfo)YtS5BeXiUYgj4IA5Ava((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), j38keGXlZrKVP6vQRHM(j38keGXlZrKVP6vQRHM(iVodlNX6tuEGlteFF07(kgK5h4X7X2ZPwdDtRb1(_003C_003Ec__DisplayClass7_, maxGhDXXm5IhkDwA5DD(typeof(_003C_003Ec__DisplayClass7_0).TypeHandle)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)YtS5BeXiUYgj4IA5Ava((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)YtS5BeXiUYgj4IA5Ava((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
								num3 = 11;
								continue;
							}
							case 8:
								try
								{
									while (true)
									{
										IL_02a9:
										int num4;
										if (!mO6l3pXRyNbZWg0rUK8(enumerator2))
										{
											num4 = 7;
											goto IL_0248;
										}
										goto IL_0286;
										IL_0248:
										while (true)
										{
											int num5;
											switch (num4)
											{
											case 8:
												break;
											case 5:
											case 10:
												goto IL_02a9;
											case 6:
												_003C_003Ec__DisplayClass7_2.permissionUid = current2.Id;
												num4 = 4;
												continue;
											default:
												assignedRoleStereotype.PermissionUid = _003C_003Ec__DisplayClass7_2.permissionUid;
												num4 = 9;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
												{
													num4 = 4;
												}
												continue;
											case 12:
												xwmFN3Xa1O5308eU1l7(groupPermissionManager, userGroup, current2);
												num5 = 3;
												goto IL_0244;
											case 4:
											{
												IEntityManager<IAssignedRoleStereotype> entityManager = assignedRoleStereotypeManager;
												ParameterExpression parameterExpression = (ParameterExpression)v6XeOhXnePv0lMLklI0(maxGhDXXm5IhkDwA5DD(typeof(IAssignedRoleStereotype).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1329706983 ^ -1329697695));
												if (CPUMaNXHlwqVtGZa55y(entityManager.Find(Expression.Lambda<Func<IAssignedRoleStereotype, bool>>((Expression)p1Pu0KXj1UN1j3X93a1(hqkRxqXNY72YFkxtsxd(j38keGXlZrKVP6vQRHM(parameterExpression, (MethodInfo)YtS5BeXiUYgj4IA5Ava((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), DjnQvYXLroAwQeREweN(iVodlNX6tuEGlteFF07(kgK5h4X7X2ZPwdDtRb1(_003C_003Ec__DisplayClass7_2, typeof(_003C_003Ec__DisplayClass7_1)), b84DCuXeAXTkstbmE2W((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), maxGhDXXm5IhkDwA5DD(typeof(Guid?).TypeHandle)), false, (MethodInfo)YtS5BeXiUYgj4IA5Ava((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), hqkRxqXNY72YFkxtsxd(j38keGXlZrKVP6vQRHM(parameterExpression, (MethodInfo)YtS5BeXiUYgj4IA5Ava((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), DjnQvYXLroAwQeREweN(iVodlNX6tuEGlteFF07(kgK5h4X7X2ZPwdDtRb1(_003C_003Ec__DisplayClass7_2, typeof(_003C_003Ec__DisplayClass7_1)), b84DCuXeAXTkstbmE2W((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), maxGhDXXm5IhkDwA5DD(typeof(Guid?).TypeHandle)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))) > 0)
												{
													num5 = 10;
													goto IL_0244;
												}
												goto case 12;
											}
											case 1:
												assignedRoleStereotype.GroupUid = _003C_003Ec__DisplayClass7_2.roleUid;
												num4 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
												{
													num4 = 0;
												}
												continue;
											case 2:
												_003C_003Ec__DisplayClass7_2 = new _003C_003Ec__DisplayClass7_1();
												num4 = 11;
												continue;
											case 11:
												_003C_003Ec__DisplayClass7_2.roleUid = spi2keXm7euZUU1a2e4(userGroup);
												num4 = 6;
												continue;
											case 9:
												assignedRoleStereotypeManager.Save(assignedRoleStereotype);
												num4 = 5;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
												{
													num4 = 4;
												}
												continue;
											case 3:
												assignedRoleStereotype = InterfaceActivator.Create<IAssignedRoleStereotype>();
												num4 = 1;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
												{
													num4 = 1;
												}
												continue;
											case 7:
												goto end_IL_02a9;
												IL_0244:
												num4 = num5;
												continue;
											}
											break;
										}
										goto IL_0286;
										IL_0286:
										current2 = enumerator2.Current;
										num4 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
										{
											num4 = 2;
										}
										goto IL_0248;
										continue;
										end_IL_02a9:
										break;
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num6 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
										{
											num6 = 1;
										}
										while (true)
										{
											switch (num6)
											{
											case 1:
												LmO0wEXwoBol39EPFQ7(enumerator2);
												num6 = 0;
												if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
												{
													num6 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto IL_057c;
							case 5:
								userGroupManager.Save(userGroup);
								num3 = 3;
								continue;
							case 11:
								if (userGroup == null)
								{
									num3 = 9;
									continue;
								}
								goto case 3;
							case 1:
							case 2:
								goto IL_057c;
							case 6:
								_003C_003Ec__DisplayClass7_.stereotype = current;
								num3 = 10;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
								{
									num3 = 10;
								}
								continue;
							case 7:
								return;
							}
							break;
						}
						goto IL_0114;
						IL_0114:
						current = enumerator.Current;
						num3 = 12;
						goto IL_004c;
					}
				}
				finally
				{
					int num7;
					if (enumerator == null)
					{
						num7 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
						{
							num7 = 1;
						}
						goto IL_05df;
					}
					goto IL_05f5;
					IL_05f5:
					LmO0wEXwoBol39EPFQ7(enumerator);
					num7 = 2;
					goto IL_05df;
					IL_05df:
					switch (num7)
					{
					case 1:
						goto end_IL_05ba;
					case 2:
						goto end_IL_05ba;
					}
					goto IL_05f5;
					end_IL_05ba:;
				}
			case 0:
				return;
			case 2:
				enumerator = (from pp in permissionProviders
					select pp.GetPermissionStereotypes() into ps
					where ps != null
					select ps).SelectMany((IEnumerable<PermissionStereotype> ps) => ps).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void Activated()
	{
		//Discarded unreachable code: IL_005e
		int num = 1;
		SecurityService service = default(SecurityService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					service = Locator.GetService<SecurityService>();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				default:
					AssignDefaultRoles();
					num2 = 3;
					continue;
				case 6:
					sd3DaEXP3Bq6fSs691Y(service);
					num2 = 5;
					continue;
				case 1:
					if (SR.GetSetting((string)QnU6ePX2ji7sQU3s8Vx(0x40944BC4 ^ 0x40945DA8), defaultValue: false))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 2:
					if (service == null)
					{
						return;
					}
					num = 6;
					break;
				}
				break;
			}
		}
	}

	public void Terminating()
	{
	}

	public void Installing(IWebModuleUnit module)
	{
	}

	public void Installed(IWebModuleUnit module)
	{
		l6HYWYXvUGrnfnPSBxU(this);
	}

	public void Enabling(IWebModuleUnit module)
	{
	}

	public void Enabled(IWebModuleUnit module)
	{
	}

	public void Disabling(IWebModuleUnit module)
	{
	}

	public void Disabled(IWebModuleUnit module)
	{
	}

	public void Uninstalling(IWebModuleUnit module)
	{
	}

	public void Uninstalled(IWebModuleUnit module)
	{
	}

	internal static Type maxGhDXXm5IhkDwA5DD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object v6XeOhXnePv0lMLklI0(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object YtS5BeXiUYgj4IA5Ava(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object kgK5h4X7X2ZPwdDtRb1(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object iVodlNX6tuEGlteFF07(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object j38keGXlZrKVP6vQRHM(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object hqkRxqXNY72YFkxtsxd(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static object epkr4NXZlHwUTMvgpRR(object P_0)
	{
		return ((PermissionStereotype)P_0).DefaultAssignee;
	}

	internal static object cKKH4kXxtTWHqxKXixU(object P_0)
	{
		return ((GroupDescriptor)P_0).Name;
	}

	internal static void RpEuMFXBgQGlqO0wc3J(object P_0, object P_1)
	{
		((IUserGroup)P_0).Name = (string)P_1;
	}

	internal static Guid GsrgifXufF7ikdNBdIs(object P_0)
	{
		return ((GroupDescriptor)P_0).Uid;
	}

	internal static Guid spi2keXm7euZUU1a2e4(object P_0)
	{
		return ((IUserGroup)P_0).Uid;
	}

	internal static object b84DCuXeAXTkstbmE2W(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object DjnQvYXLroAwQeREweN(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object p1Pu0KXj1UN1j3X93a1(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static int CPUMaNXHlwqVtGZa55y(object P_0)
	{
		return ((ICollection<IAssignedRoleStereotype>)P_0).Count;
	}

	internal static void xwmFN3Xa1O5308eU1l7(object P_0, object P_1, object P_2)
	{
		((GroupPermissionManager)P_0).GrantPermission((IUserGroup)P_1, (Permission)P_2);
	}

	internal static bool mO6l3pXRyNbZWg0rUK8(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void LmO0wEXwoBol39EPFQ7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool WAE5cUXANo6YXh5RLYp()
	{
		return b9mmddX5XVupUbc4uVw == null;
	}

	internal static DefaultRoleAssignee FM0bY1XWIwwwQ1BvXxw()
	{
		return b9mmddX5XVupUbc4uVw;
	}

	internal static object QnU6ePX2ji7sQU3s8Vx(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void sd3DaEXP3Bq6fSs691Y(object P_0)
	{
		((SecurityService)P_0).ResetPermissionsCache();
	}

	internal static void l6HYWYXvUGrnfnPSBxU(object P_0)
	{
		((DefaultRoleAssignee)P_0).AssignDefaultRoles();
	}
}
