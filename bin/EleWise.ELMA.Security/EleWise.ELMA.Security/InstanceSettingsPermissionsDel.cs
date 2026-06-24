using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component(Order = int.MaxValue)]
public class InstanceSettingsPermissionsDelegate : IPermissionsDelegate
{
	private readonly Func<Type, bool> hasInstanceSettingsPermissionCacheFunc;

	private readonly Func<Type, Guid, bool> hasPermissionRoleTypeProviderCacheFunc;

	internal static InstanceSettingsPermissionsDelegate atJB1m67r7HQrOCl9sZ;

	public InstanceSettingsPermissionsDelegate(IMemoryCacheService memoryCacheService, Func<IEnumerable<IInstanceSettingsPermission>> instanceSettingsPermissions, Func<IEnumerable<IPermissionRoleTypeProvider>> permissionRoleTypeProviders)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.instanceSettingsPermissions = instanceSettingsPermissions;
		_003C_003Ec__DisplayClass2_.permissionRoleTypeProviders = permissionRoleTypeProviders;
		base._002Ector();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(Type), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28EBA022 ^ 0x28EB8B90));
		MethodInfo method = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		Expression[] obj = new Expression[2]
		{
			Expression.Invoke(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))),
			null
		};
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IInstanceSettingsPermission), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1801396866 ^ -1801390394));
		obj[1] = Expression.Lambda<Func<IInstanceSettingsPermission, bool>>(Expression.AndAlso(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2]
		{
			parameterExpression,
			Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))
		}), Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)))), new ParameterExpression[1] { parameterExpression2 });
		hasInstanceSettingsPermissionCacheFunc = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, bool>>(Expression.Call(null, method, obj), new ParameterExpression[1] { parameterExpression }));
		parameterExpression = Expression.Parameter(typeof(Type), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x161AA30));
		parameterExpression2 = Expression.Parameter(typeof(Guid), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E673310));
		MethodInfo method2 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		Expression[] obj2 = new Expression[2]
		{
			Expression.Invoke(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))),
			null
		};
		ParameterExpression parameterExpression3 = Expression.Parameter(typeof(IPermissionRoleTypeProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1618182 ^ 0x161AA4A));
		MethodInfo method3 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		Expression[] obj3 = new Expression[2]
		{
			Expression.Call(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Array.Empty<Expression>()),
			null
		};
		ParameterExpression parameterExpression4 = Expression.Parameter(typeof(PermissionRoleTypeStereotype), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858473711 ^ -1858479419));
		obj3[1] = Expression.Lambda<Func<PermissionRoleTypeStereotype, bool>>(Expression.AndAlso(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2]
		{
			parameterExpression,
			Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))
		}), Expression.Equal(Expression.Property(Expression.Property(parameterExpression4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), parameterExpression2, liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression4 });
		obj2[1] = Expression.Lambda<Func<IPermissionRoleTypeProvider, bool>>(Expression.Call(null, method3, obj3), new ParameterExpression[1] { parameterExpression3 });
		hasPermissionRoleTypeProviderCacheFunc = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, Guid, bool>>(Expression.Call(null, method2, obj2), new ParameterExpression[2] { parameterExpression, parameterExpression2 }));
	}

	protected virtual bool HasInstanceSettingsPermission(Type type)
	{
		return hasInstanceSettingsPermissionCacheFunc(type);
	}

	protected virtual bool HasPermissionRoleTypeProvider(Type type, Permission permission)
	{
		return hasPermissionRoleTypeProviderCacheFunc(type, LISNQC6NRBOwHv7BjID(permission));
	}

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_00e2, IL_00f1, IL_0101
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return K2Itju6uSkjQ3eE61uy(this, type, permission);
			case 7:
				return true;
			case 3:
			case 6:
				return false;
			case 4:
				if (!Uy7oFX6Z4b752CdetJ5(permission, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 2:
				if (permission.PermissionType == PermissionType.Instance)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 1:
				if (H7yJww6BtAyD3cgeTcW(permission))
				{
					num2 = 7;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 5;
			case 8:
				if (!HasInstanceSettingsPermission(type))
				{
					num2 = 6;
					break;
				}
				goto case 1;
			default:
				if (VZjZcB6xBkZVSR7Kptg(type, null))
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual bool HasPermission([NotNull] IUser user, [NotNull] Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_0176
		int num = 9;
		IEntityManager entityManager = default(IEntityManager);
		IEntity entity = default(IEntity);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (user == null)
					{
						num2 = 8;
						continue;
					}
					if (!zJx9eu6eLvEgndJHRg8(permission, null))
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				case 2:
					if (entityManager != null)
					{
						num = 5;
						break;
					}
					return false;
				case 5:
				{
					IEntityManager entityManager2 = entityManager;
					Filter obj = new Filter
					{
						PermissionId = LISNQC6NRBOwHv7BjID(permission)
					};
					XqM42J6a3KjmVCZn4U1(obj, user);
					y3X9nK6RvhNHx0VDOr6(obj, entity.GetId());
					WBvMld6wSwkDYHABdQb(obj, skipAdmin);
					TZ7Ft462GJqTmcS7txB(obj, true);
					return vGpiq06P0wonimUydd3(entityManager2, obj);
				}
				case 1:
					if (!oouZiV6HoNlbbdjBfkc(this, type))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					entityManager = EntityHelper.GetEntityManager(type);
					num = 2;
					break;
				default:
					throw new InvalidOperationException((string)yJy8FS6L5HomUsx26dt(jVoktU6m4pB5dSVTw56(0x38328F00 ^ 0x38329760), new object[1] { type }));
				case 8:
					throw new ArgumentNullException((string)jVoktU6m4pB5dSVTw56(0x7DABA580 ^ 0x7DABA86A));
				case 7:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1757426405 ^ -1757422699));
				case 6:
					entity = target as IEntity;
					num2 = 4;
					continue;
				case 3:
					throw new InvalidOperationException((string)yJy8FS6L5HomUsx26dt(jVoktU6m4pB5dSVTw56(0x4A799728 ^ 0x4A79888E), new object[1] { target }));
				case 4:
					if (entity != null)
					{
						type = adRemH6joFy68iJeMCu(target);
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
						{
							num2 = 3;
						}
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool JnyIYj66xb9AfS1ikqi()
	{
		return atJB1m67r7HQrOCl9sZ == null;
	}

	internal static InstanceSettingsPermissionsDelegate Po2hqE6l8cKSam24VKo()
	{
		return atJB1m67r7HQrOCl9sZ;
	}

	internal static Guid LISNQC6NRBOwHv7BjID(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool Uy7oFX6Z4b752CdetJ5(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static bool VZjZcB6xBkZVSR7Kptg(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool H7yJww6BtAyD3cgeTcW(object P_0)
	{
		return ((Permission)P_0).IsInstanceSettingsPermission;
	}

	internal static bool K2Itju6uSkjQ3eE61uy(object P_0, Type type, object P_2)
	{
		return ((InstanceSettingsPermissionsDelegate)P_0).HasPermissionRoleTypeProvider(type, (Permission)P_2);
	}

	internal static object jVoktU6m4pB5dSVTw56(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool zJx9eu6eLvEgndJHRg8(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static object yJy8FS6L5HomUsx26dt(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static Type adRemH6joFy68iJeMCu(object P_0)
	{
		return EntityHelper.GetType(P_0);
	}

	internal static bool oouZiV6HoNlbbdjBfkc(object P_0, Type type)
	{
		return ((InstanceSettingsPermissionsDelegate)P_0).HasInstanceSettingsPermission(type);
	}

	internal static void XqM42J6a3KjmVCZn4U1(object P_0, object P_1)
	{
		((Filter)P_0).PermissionUser = (IUser)P_1;
	}

	internal static void y3X9nK6RvhNHx0VDOr6(object P_0, object P_1)
	{
		((Filter)P_0).Id = P_1;
	}

	internal static void WBvMld6wSwkDYHABdQb(object P_0, bool P_1)
	{
		((Filter)P_0).SkipAdminPermission = P_1;
	}

	internal static void TZ7Ft462GJqTmcS7txB(object P_0, bool P_1)
	{
		((Filter)P_0).DisableSoftDeletable = P_1;
	}

	internal static bool vGpiq06P0wonimUydd3(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Exists((IEntityFilter)P_1);
	}
}
