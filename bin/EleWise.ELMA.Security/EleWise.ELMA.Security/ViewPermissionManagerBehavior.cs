using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Component(Order = 1)]
internal class ViewPermissionManagerBehavior : EntityManagerBehavior
{
	private readonly ISecurityService securityService;

	private readonly IAuthenticationService authenticationService;

	internal static ViewPermissionManagerBehavior F8fGnXNsYVoKE4Gq7mC;

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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ViewPermissionManagerBehavior(ISecurityService securityService, IAuthenticationService authenticationService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.authenticationService = authenticationService;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				this.securityService = securityService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void OnLoad(object target)
	{
		//Discarded unreachable code: IL_00ac, IL_00bb, IL_017f, IL_0206, IL_0210, IL_021f, IL_022e, IL_023e, IL_0277, IL_0281, IL_02f2
		int num = 20;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		Type type = default(Type);
		IEntityManager entityManager = default(IEntityManager);
		IEntity entity = default(IEntity);
		EntityMetadata entityMetadata = default(EntityMetadata);
		object obj4;
		string text2 = default(string);
		object obj3 = default(object);
		string text = default(string);
		while (true)
		{
			object obj;
			object obj2;
			switch (num2)
			{
			case 2:
				return;
			case 12:
				return;
			case 18:
				user = (EleWise.ELMA.Security.Models.IUser)reofSINQr8FRbWsGTQO(authenticationService);
				num2 = 17;
				continue;
			case 22:
				type = p3qv2VNgeuVh9MJnYG3(target);
				num2 = 21;
				continue;
			case 1:
				return;
			case 7:
				if (target == null)
				{
					num2 = 12;
					continue;
				}
				goto case 4;
			case 14:
				return;
			case 19:
				if (lflul9N4LXdLNSRpST1(RunWithElevatedPrivilegiesService))
				{
					return;
				}
				num2 = 7;
				continue;
			case 4:
				if (!cmbN3yNVb17bipC9OqF(securityService, CommonPermissions.View, target))
				{
					return;
				}
				num2 = 18;
				continue;
			case 11:
				entityManager = EntityHelper.GetEntityManager(type);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 20:
				if (SecurityService.DisableSecurityBySettings)
				{
					return;
				}
				num2 = 19;
				continue;
			case 9:
				if (entity != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 15;
			case 15:
				obj = SHEYZFNdJpf6BtH1kUt(-1195916818 ^ -1195901760);
				goto IL_0315;
			case 21:
				entityMetadata = bXFFusN8inSv6iJAbNp(type, false, false) as EntityMetadata;
				num2 = 16;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
				{
					num2 = 14;
				}
				continue;
			default:
				if (entityManager == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
					{
						num2 = 13;
					}
					continue;
				}
				obj4 = entityManager.CreateSecurityException(text2, obj3);
				break;
			case 13:
				obj4 = new EntitySecurityException(text2)
				{
					EntityId = waa4KnNy2uA8O27mQPQ(obj3)
				};
				mqsMCGNb32UYrfXB3XW(obj4, InterfaceActivator.UID(type));
				((EntitySecurityException)obj4).PermissionId = CommonPermissions.View.Id;
				break;
			case 10:
				return;
			case 17:
				if (securityService.HasPermission(user, CommonPermissions.View, target))
				{
					num2 = 10;
					continue;
				}
				goto case 3;
			case 6:
				obj2 = type.FullName;
				goto IL_0328;
			case 8:
				text2 = (string)a0Ep9rN309w9Hejl2F3(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788394408), new object[2] { text, obj3 });
				num2 = 11;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
				{
					num2 = 8;
				}
				continue;
			case 16:
				if (entityMetadata == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				obj2 = pckJMxNrwSeDLr4pZBH(entityMetadata);
				goto IL_0328;
			case 3:
				entity = target as IEntity;
				num2 = 9;
				continue;
			case 5:
				{
					obj = E3PBYNNTlhm45kXYRjT(entity);
					goto IL_0315;
				}
				IL_0315:
				obj3 = obj;
				num2 = 22;
				continue;
				IL_0328:
				text = (string)obj2;
				num2 = 8;
				continue;
			}
			break;
		}
		throw obj4;
	}

	internal static bool GjK8KsNYe1yXYJEIpIS()
	{
		return F8fGnXNsYVoKE4Gq7mC == null;
	}

	internal static ViewPermissionManagerBehavior oNnCPUNIDOHwRX7UiPp()
	{
		return F8fGnXNsYVoKE4Gq7mC;
	}

	internal static bool lflul9N4LXdLNSRpST1(object P_0)
	{
		return ((RunWithElevatedPrivilegiesService)P_0).Turned;
	}

	internal static bool cmbN3yNVb17bipC9OqF(object P_0, object P_1, object P_2)
	{
		return ((ISecurityService)P_0).CanCheckPermission((Permission)P_1, P_2);
	}

	internal static object reofSINQr8FRbWsGTQO(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object SHEYZFNdJpf6BtH1kUt(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object E3PBYNNTlhm45kXYRjT(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static Type p3qv2VNgeuVh9MJnYG3(object P_0)
	{
		return EntityHelper.GetType(P_0);
	}

	internal static object bXFFusN8inSv6iJAbNp(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object pckJMxNrwSeDLr4pZBH(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object a0Ep9rN309w9Hejl2F3(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static long waa4KnNy2uA8O27mQPQ(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void mqsMCGNb32UYrfXB3XW(object P_0, Guid P_1)
	{
		((EntitySecurityException)P_0).TypeUid = P_1;
	}
}
