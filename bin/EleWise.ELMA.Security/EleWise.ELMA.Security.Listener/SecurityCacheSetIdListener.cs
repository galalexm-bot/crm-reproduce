using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component]
internal class SecurityCacheSetIdListener : EntityEventsListener
{
	private static SecurityCacheSetIdListener SqF7uIaPNABLdeALwvS;

	public RunWithSoftDeletableService RunWithSoftDeletableService
	{
		[CompilerGenerated]
		get
		{
			return _003CRunWithSoftDeletableService_003Ek__BackingField;
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
				case 1:
					_003CRunWithSoftDeletableService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 4;
		int num2 = num;
		ISecuritySetIdHolder securitySetIdHolder = default(ISecuritySetIdHolder);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 2:
				SetId(securitySetIdHolder, ((AbstractPreDatabaseOperationEvent)@event).get_Persister(), (object[])HtGOkRaUkQC9bx2BJLt(@event));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return false;
			case 4:
				securitySetIdHolder = ((AbstractPreDatabaseOperationEvent)@event).get_Entity() as ISecuritySetIdHolder;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				if (securitySetIdHolder != null)
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	private void SetId(ISecuritySetIdHolder securitySetIdHolder, IEntityPersister persister, object[] state)
	{
		//Discarded unreachable code: IL_0178, IL_01f0, IL_0263, IL_0272, IL_02ab, IL_02ba, IL_02ca, IL_02fc, IL_030b, IL_0378, IL_0387, IL_0494, IL_04a7, IL_04b6
		int num = 1;
		int num2 = num;
		long? num4 = default(long?);
		IEntity entity = default(IEntity);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		EleWise.ELMA.Security.Models.IUser user = default(EleWise.ELMA.Security.Models.IUser);
		IUserGroup userGroup = default(IUserGroup);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num4 = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				try
				{
					int num3;
					if (pfg15baKHbXS3aspFuo(securitySetIdHolder) == null)
					{
						num3 = 15;
					}
					else
					{
						entity = (IEntity)pfg15baKHbXS3aspFuo(securitySetIdHolder);
						num3 = 22;
					}
					while (true)
					{
						switch (num3)
						{
						case 25:
							num4 = UserSecuritySetHelper.GetOrganizationItemMask(organizationItem.Id);
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f != 0)
							{
								num3 = 1;
							}
							break;
						case 14:
							num4 = nc396yaFkydaP2g6vNg(user.Id);
							num3 = 4;
							break;
						case 6:
						case 8:
							throw new ArgumentException((string)UWkL8aacw8QFpZeBM89(-1826813434 ^ -1826798428));
						case 1:
						case 12:
							user = entity as EleWise.ELMA.Security.Models.IUser;
							num3 = 24;
							break;
						case 21:
							if (Y25SmvaqnfESbQkQJXZ(hvYqBjatdbprj2Yepiw(securitySetIdHolder), OJqbnIahano2idZVSKG(CommonRoleTypes.User)))
							{
								num3 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
								{
									num3 = 3;
								}
								break;
							}
							goto case 6;
						case 15:
							if (!ePbIlZaOF8cu3cfC6LV(hvYqBjatdbprj2Yepiw(securitySetIdHolder), OJqbnIahano2idZVSKG(CommonRoleTypes.Group)))
							{
								num3 = 23;
								break;
							}
							goto case 27;
						case 11:
							if (organizationItem == null)
							{
								num3 = 12;
								break;
							}
							goto case 25;
						case 16:
							return;
						case 26:
							if (!(hvYqBjatdbprj2Yepiw(securitySetIdHolder) != OJqbnIahano2idZVSKG(CommonRoleTypes.Group)))
							{
								num3 = 6;
								break;
							}
							goto case 21;
						case 3:
							num4 = -1L;
							num3 = 5;
							break;
						case 29:
							num4 = oVtwAsaGP5UBiNf9pxB(userGroup.Id);
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
							{
								num3 = 0;
							}
							break;
						case 13:
							return;
						case 27:
							if (UserSecuritySetHelper.IsGroup(securitySetIdHolder.UserSecuritySetCacheId))
							{
								num3 = 9;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 != 0)
								{
									num3 = 7;
								}
								break;
							}
							goto case 2;
						case 22:
							userGroup = entity as IUserGroup;
							num3 = 28;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
							{
								num3 = 27;
							}
							break;
						case 9:
							return;
						case 7:
						case 17:
							if (num4.HasValue)
							{
								num3 = 19;
								break;
							}
							goto case 18;
						default:
							organizationItem = entity as IOrganizationItem;
							num3 = 11;
							break;
						case 28:
							if (userGroup != null)
							{
								num3 = 29;
								break;
							}
							goto default;
						case 2:
						case 23:
							if (ePbIlZaOF8cu3cfC6LV(hvYqBjatdbprj2Yepiw(securitySetIdHolder), OJqbnIahano2idZVSKG(CommonRoleTypes.OrganizationItem)))
							{
								num3 = 13;
								break;
							}
							goto case 26;
						case 20:
							securitySetIdHolder.UserSecuritySetCacheId = num4;
							num3 = 10;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
							{
								num3 = 10;
							}
							break;
						case 24:
							if (user != null)
							{
								num3 = 14;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 4;
						case 4:
						{
							if (entity is PropertyMetadataReference)
							{
								return;
							}
							int num5 = 17;
							num3 = num5;
							break;
						}
						case 18:
							throw new InvalidOperationException((string)u7VBbpa02xjlX4CmbW7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCD88DD8 ^ 0xCD8C336), new object[2]
							{
								(entity != null) ? entity.ToString() : UWkL8aacw8QFpZeBM89(0x7CAA49C6 ^ 0x7CAA5DEA),
								securitySetIdHolder
							}));
						case 5:
						case 19:
							DB6WVnaEKVby6SSyuqt(persister, state, UWkL8aacw8QFpZeBM89(0x335D4787 ^ 0x335D08D3), num4);
							num3 = 20;
							break;
						case 10:
							return;
						}
					}
				}
				finally
				{
					udOF6raJmtZgLv41KKX(RunWithSoftDeletableService, flag);
					int num6 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			case 2:
				return;
			case 3:
				udOF6raJmtZgLv41KKX(RunWithSoftDeletableService, true);
				num2 = 4;
				break;
			default:
				flag = yfvPfnaorFtL6pIyYgX(RunWithSoftDeletableService);
				num2 = 3;
				break;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 4;
		int num2 = num;
		ISecuritySetIdHolder securitySetIdHolder = default(ISecuritySetIdHolder);
		while (true)
		{
			switch (num2)
			{
			case 4:
				securitySetIdHolder = xJJTf7aDGO1wOnLky66(@event) as ISecuritySetIdHolder;
				num2 = 3;
				break;
			case 3:
				if (securitySetIdHolder != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 2:
				return false;
			default:
				return false;
			case 1:
				SetId(securitySetIdHolder, ((AbstractPreDatabaseOperationEvent)@event).get_Persister(), (object[])Vdo5ZNaMbfD4L9kyFys(@event));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public SecurityCacheSetIdListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EjYlAyavHXd6iCE3QgJ()
	{
		return SqF7uIaPNABLdeALwvS == null;
	}

	internal static SecurityCacheSetIdListener A1Mo6oaCbJelrbmjywf()
	{
		return SqF7uIaPNABLdeALwvS;
	}

	internal static object HtGOkRaUkQC9bx2BJLt(object P_0)
	{
		return ((PreInsertEvent)P_0).get_State();
	}

	internal static bool yfvPfnaorFtL6pIyYgX(object P_0)
	{
		return ((RunWithSoftDeletableService)P_0).Turned;
	}

	internal static void udOF6raJmtZgLv41KKX(object P_0, bool P_1)
	{
		((RunWithSoftDeletableService)P_0).Turned = P_1;
	}

	internal static object pfg15baKHbXS3aspFuo(object P_0)
	{
		return ((IInstanceSettingsPermissionHolder)P_0).Assigned;
	}

	internal static Guid hvYqBjatdbprj2Yepiw(object P_0)
	{
		return ((IInstanceSettingsPermissionHolder)P_0).TypeRoleId;
	}

	internal static Guid OJqbnIahano2idZVSKG(object P_0)
	{
		return ((PermissionRoleType)P_0).Id;
	}

	internal static bool ePbIlZaOF8cu3cfC6LV(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool Y25SmvaqnfESbQkQJXZ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object UWkL8aacw8QFpZeBM89(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long oVtwAsaGP5UBiNf9pxB(long id)
	{
		return UserSecuritySetHelper.GetGroupMask(id);
	}

	internal static long nc396yaFkydaP2g6vNg(long id)
	{
		return UserSecuritySetHelper.GetUserMask(id);
	}

	internal static object u7VBbpa02xjlX4CmbW7(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void DB6WVnaEKVby6SSyuqt(object P_0, object P_1, object P_2, object P_3)
	{
		((IEntityPersister)P_0).Set((object[])P_1, (string)P_2, P_3);
	}

	internal static object xJJTf7aDGO1wOnLky66(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object Vdo5ZNaMbfD4L9kyFys(object P_0)
	{
		return ((PreUpdateEvent)P_0).get_State();
	}
}
