using System;
using System.Collections.Generic;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component(Order = 100)]
public class InstanceExpressionPermissionsDelegate : IPermissionsDelegate
{
	private readonly IMemoryCacheService memoryCacheService;

	private readonly IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions;

	internal static InstanceExpressionPermissionsDelegate ugEYSwWMI6rB1eH3tpp;

	public InstanceExpressionPermissionsDelegate(IMemoryCacheService memoryCacheService, IEnumerable<IInstanceExpressionPermission> instanceExpressionPermissions)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		if (memoryCacheService == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580400259));
		}
		if (instanceExpressionPermissions == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46347DA6 ^ 0x4634637E));
		}
		this.memoryCacheService = memoryCacheService;
		this.instanceExpressionPermissions = instanceExpressionPermissions;
	}

	[ContextCache]
	protected virtual bool HasInstanceExpressionPermission(Type type)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass3_.type = type;
				num2 = 3;
				break;
			default:
				_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return memoryCacheService.GetOrAdd((string)fKrMNMW4ccBgbt8wkdX(zNJKKYWIcrPVXNyRxa6(0x432996D0 ^ 0x432989C6), _003C_003Ec__DisplayClass3_.type.FullName), _003C_003Ec__DisplayClass3_._003CHasInstanceExpressionPermission_003Eb__0);
			}
		}
	}

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_00be, IL_00f3, IL_0102
		int num = 8;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (!IoYuPJWVs9adaGJ4BYd(permission, null))
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				default:
					if (!kwy7TcWdNPohBVwAOaA(permission, CommonPermissions.View))
					{
						num = 4;
						break;
					}
					goto case 5;
				case 3:
					if (eLgcQnWQeBKef99G3xK(permission) == PermissionType.Instance)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 5:
					if (!(type != null))
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 2:
					return EfgplPWgX7Rud8BUTna(this, type);
				case 1:
				case 6:
				case 7:
					return false;
				case 4:
					if (!((Permission)rkudB9WT3Vud0kLYtvP(permission) == CommonPermissions.View))
					{
						num = 6;
						break;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	public virtual bool HasPermission([NotNull] IUser user, [NotNull] Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_00f4, IL_0103, IL_0112
		int num = 10;
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
				case 2:
					throw new ArgumentNullException((string)zNJKKYWIcrPVXNyRxa6(0xA5DAE86 ^ 0xA5DA36C));
				case 9:
					if (!kwy7TcWdNPohBVwAOaA(permission, null))
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				case 4:
				{
					IEntityManager entityManager2 = entityManager;
					Filter obj = new Filter
					{
						PermissionId = wRVYJhW3exQdLYfR3Lr(permission),
						PermissionUser = user,
						Id = entity.GetId()
					};
					HBgAGTWyZySwJUscZ0p(obj, skipAdmin);
					Rasc0OWbu8PGN0EDNIo(obj, true);
					return JK2LsgWSuQJa14ijD4J(entityManager2, obj);
				}
				case 8:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-236222459 ^ -236216693));
				case 7:
					break;
				case 3:
					if (entity == null)
					{
						num2 = 5;
						continue;
					}
					type = EntityHelper.GetType(target);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (user != null)
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				default:
					if (!HasInstanceExpressionPermission(type))
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
						{
							num2 = 4;
						}
						continue;
					}
					entityManager = (IEntityManager)xK83boWroaZRtkcjvhh(type);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					throw new InvalidOperationException((string)GRHTWSW8A5KLbbCrOEF(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-764392425 ^ -764390281), new object[1] { type }));
				case 5:
					throw new InvalidOperationException((string)GRHTWSW8A5KLbbCrOEF(zNJKKYWIcrPVXNyRxa6(-1084772212 ^ -1084772566), new object[1] { target }));
				case 1:
					if (entityManager == null)
					{
						return false;
					}
					num2 = 4;
					continue;
				}
				break;
			}
			entity = target as IEntity;
			num = 3;
		}
	}

	internal static object zNJKKYWIcrPVXNyRxa6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fKrMNMW4ccBgbt8wkdX(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool YJ7cXPWsM5oulxiCxcX()
	{
		return ugEYSwWMI6rB1eH3tpp == null;
	}

	internal static InstanceExpressionPermissionsDelegate Oki4frWYL5DwddBtG6C()
	{
		return ugEYSwWMI6rB1eH3tpp;
	}

	internal static bool IoYuPJWVs9adaGJ4BYd(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static PermissionType eLgcQnWQeBKef99G3xK(object P_0)
	{
		return ((Permission)P_0).PermissionType;
	}

	internal static bool kwy7TcWdNPohBVwAOaA(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static object rkudB9WT3Vud0kLYtvP(object P_0)
	{
		return ((Permission)P_0).Base;
	}

	internal static bool EfgplPWgX7Rud8BUTna(object P_0, Type type)
	{
		return ((InstanceExpressionPermissionsDelegate)P_0).HasInstanceExpressionPermission(type);
	}

	internal static object GRHTWSW8A5KLbbCrOEF(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object xK83boWroaZRtkcjvhh(Type P_0)
	{
		return EntityHelper.GetEntityManager(P_0);
	}

	internal static Guid wRVYJhW3exQdLYfR3Lr(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static void HBgAGTWyZySwJUscZ0p(object P_0, bool P_1)
	{
		((Filter)P_0).SkipAdminPermission = P_1;
	}

	internal static void Rasc0OWbu8PGN0EDNIo(object P_0, bool P_1)
	{
		((Filter)P_0).DisableSoftDeletable = P_1;
	}

	internal static bool JK2LsgWSuQJa14ijD4J(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Exists((IEntityFilter)P_1);
	}
}
