using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component]
internal class ProfilePermissionsDelegate : IPermissionsDelegate
{
	private readonly IEnumerable<IProfileResolver> profileResolvers;

	private readonly IEnumerable<IProfilePermission> profilePermissions;

	private readonly ISecurityService securityService;

	private Func<Type, Type> resolveProfileType;

	private Func<Permission, Type, Permission> resolvePermission;

	private static ProfilePermissionsDelegate JxZIRvNk4OgxUXIVFsm;

	public ProfilePermissionsDelegate(IEnumerable<IProfileResolver> profileResolvers, IEnumerable<IProfilePermission> profilePermissions, ISecurityService securityService)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.profileResolvers = profileResolvers;
		this.profilePermissions = profilePermissions;
		this.securityService = securityService;
		ParameterExpression parameterExpression = Expression.Parameter(typeof(Type), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1983795824 ^ 0x763E4A34));
		resolveProfileType = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Type, Type>>(Expression.Call(Expression.Constant(this, typeof(ProfilePermissionsDelegate)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression), new ParameterExpression[1] { parameterExpression }));
		parameterExpression = Expression.Parameter(typeof(Permission), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x67DFA65E ^ 0x67DFB0D0));
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(Type), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1642017152 ^ -1642015036));
		resolvePermission = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<Permission, Type, Permission>>(Expression.Call(Expression.Constant(this, typeof(ProfilePermissionsDelegate)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), new Expression[2] { parameterExpression, parameterExpression2 }), new ParameterExpression[2] { parameterExpression, parameterExpression2 }));
	}

	[ContextCache]
	protected virtual Type ResolveProfileType(Type type)
	{
		return resolveProfileType(type);
	}

	[ContextCache]
	protected virtual object ResolveProfile(Type type)
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
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass7_.type = type;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return profileResolvers.Select(_003C_003Ec__DisplayClass7_._003CResolveProfile_003Eb__0).FirstOrDefault((object t) => t != null);
			}
		}
	}

	[ContextCache]
	protected virtual Permission ResolveTypeProfilePermission(Permission permission, Type profileType)
	{
		return resolvePermission(permission, profileType);
	}

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		//Discarded unreachable code: IL_00b0
		int num = 1;
		int num2 = num;
		Type profileType = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				if (FObe9nNWomLwDPQIy7g(permission, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_73b92e1f752f422d899693d4318e4486 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 1:
				if (uxHvHCNAAcY97DjPc4J(type, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				if (!((profileType = ResolveProfileType(type)) != null))
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 4;
			case 4:
				return ResolveTypeProfilePermission(permission, profileType) != null;
			case 3:
				break;
			}
			break;
		}
		return false;
	}

	public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_00e4, IL_00f3, IL_0119, IL_018f, IL_0222, IL_0231
		int num = 20;
		EntityMetadata entityMetadata = default(EntityMetadata);
		Type type = default(Type);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					if (target != null)
					{
						num2 = 19;
						break;
					}
					goto case 3;
				case 14:
					if (!Qmfpv9NiaHNuiFsNykp(entityMetadata))
					{
						num2 = 14;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
						{
							num2 = 15;
						}
						break;
					}
					goto case 12;
				case 7:
					entityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
					num2 = 18;
					break;
				case 1:
					if (permission == null)
					{
						num2 = 10;
						break;
					}
					return g4C41bNlo26J1pLVBsF(securityService, user, permission, obj, false);
				case 13:
					if (y6L9nINnTIgrFKenu41(permission) == PermissionType.Instance)
					{
						num2 = 7;
						break;
					}
					goto case 4;
				case 8:
					if (!uxHvHCNAAcY97DjPc4J(type, null))
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 3:
					return false;
				case 9:
					type = target as Type;
					num2 = 16;
					break;
				default:
					if (!type.IsInheritOrSame<IEntity>())
					{
						num2 = 4;
						break;
					}
					goto case 13;
				case 17:
					if (obj != null)
					{
						num2 = 11;
						break;
					}
					goto case 2;
				case 2:
					return false;
				case 11:
					permission = (Permission)Qmki6iN6XjSmspjymVa(this, permission, EntityHelper.GetType(obj));
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					type = EntityHelper.GetType(target);
					num2 = 8;
					break;
				case 19:
					if (!(permission == null))
					{
						num2 = 9;
						break;
					}
					goto case 3;
				case 16:
					if (s2dOFENXlbIwB37LkUO(type, null))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 12:
					return false;
				case 4:
				case 6:
				case 15:
					obj = JgtABjN7iLUgwYShERW(this, type);
					num2 = 17;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
					{
						num2 = 11;
					}
					break;
				case 10:
					return false;
				case 18:
					if (entityMetadata != null)
					{
						num2 = 14;
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private bool PermissionsEquals(Permission permission1, Permission permission2)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return PermissionsEquals(permission1, (Permission)Mo0cNFNxSlWP1QEvt9x(permission2));
			case 1:
				if (permission2 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (MLR6slNZMnUf9pEcBBs(JamHA0NN2cxpea9IUwD(permission1), JamHA0NN2cxpea9IUwD(permission2)))
				{
					return true;
				}
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4162f809c129429a9879671f23845052 != 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				if (!(permission1 == null))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f87584a8fee4f91864943acbd35d6d6 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			break;
		}
		return false;
	}

	private Type GetTypeByResolver(Type type)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass12_.type = type;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return profileResolvers.Select(_003C_003Ec__DisplayClass12_._003CGetTypeByResolver_003Eb__0).FirstOrDefault((Type t) => _003C_003Ec.KgSh7Rp6BGb4osyqUHg2(t, null));
			}
		}
	}

	private Permission GetPermissionByProfile(Permission permission, Type profileType)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass13_.permission = permission;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass13_._003C_003E4__this = this;
				num2 = 2;
				break;
			default:
				_003C_003Ec__DisplayClass13_.profileType = profileType;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return (from d in profilePermissions.SelectMany((IProfilePermission p) => p.ProfilePermissionDescriptors).Where(_003C_003Ec__DisplayClass13_._003CGetPermissionByProfile_003Eb__1)
					select (Permission)_003C_003Ec.uV2PP7p6uqLlK02NIn9I(d)).FirstOrDefault();
			}
		}
	}

	internal static bool Fx0A7fNpqZTtyFVguiF()
	{
		return JxZIRvNk4OgxUXIVFsm == null;
	}

	internal static ProfilePermissionsDelegate MijEqsN53Ab0l4IqKn8()
	{
		return JxZIRvNk4OgxUXIVFsm;
	}

	internal static bool uxHvHCNAAcY97DjPc4J(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool FObe9nNWomLwDPQIy7g(object P_0, object P_1)
	{
		return (Permission)P_0 != (Permission)P_1;
	}

	internal static bool s2dOFENXlbIwB37LkUO(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static PermissionType y6L9nINnTIgrFKenu41(object P_0)
	{
		return ((Permission)P_0).PermissionType;
	}

	internal static bool Qmfpv9NiaHNuiFsNykp(object P_0)
	{
		return ((EntityMetadata)P_0).CanUsePermissions();
	}

	internal static object JgtABjN7iLUgwYShERW(object P_0, Type type)
	{
		return ((ProfilePermissionsDelegate)P_0).ResolveProfile(type);
	}

	internal static object Qmki6iN6XjSmspjymVa(object P_0, object P_1, Type profileType)
	{
		return ((ProfilePermissionsDelegate)P_0).ResolveTypeProfilePermission((Permission)P_1, profileType);
	}

	internal static bool g4C41bNlo26J1pLVBsF(object P_0, object P_1, object P_2, object P_3, bool P_4)
	{
		return ((ISecurityService)P_0).HasPermission((IUser)P_1, (Permission)P_2, P_3, P_4);
	}

	internal static Guid JamHA0NN2cxpea9IUwD(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool MLR6slNZMnUf9pEcBBs(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object Mo0cNFNxSlWP1QEvt9x(object P_0)
	{
		return ((Permission)P_0).Base;
	}
}
