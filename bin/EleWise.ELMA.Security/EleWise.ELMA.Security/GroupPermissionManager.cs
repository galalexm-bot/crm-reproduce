using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security.Events;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Type = ComponentType.Server, EnableInterceptors = true, InjectProperties = true)]
public class GroupPermissionManager : NHManager
{
	private IGroupPermissionEventHandler _groupPermissionEventHandler;

	internal static GroupPermissionManager rpCwTPiffKkySApKtr2;

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
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
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
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

	private IGroupPermissionEventHandler GroupPermissionEventHandler
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_groupPermissionEventHandler = Locator.GetService<IGroupPermissionEventHandler>();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (_groupPermissionEventHandler == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				break;
			}
			return _groupPermissionEventHandler;
		}
	}

	[Transaction]
	public virtual void GrantPermission(IUserGroup group, Permission permission)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_0109, IL_0118, IL_014c, IL_017f, IL_0218
		//IL_0165: Expected O, but got Unknown
		int num = 5;
		GroupPermission groupPermission = default(GroupPermission);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 7:
					return;
				case 9:
					if (GroupPermissionEventHandler == null)
					{
						num2 = 7;
						break;
					}
					goto case 8;
				case 6:
					throw new ArgumentNullException((string)pkpCWO7kRUmAeHpuENh(0x1B3723C5 ^ 0x1B37354B));
				case 8:
					Q5sO3K7lRYRf3bMIsub(GroupPermissionEventHandler, new GroupPermissionEventArgs(groupPermission, GroupPermissionOperation.Add, permission));
					num2 = 2;
					break;
				case 2:
					return;
				case 1:
					try
					{
						HPCbby7iSk1EHP6pbPj(etjQFV7nmRZmwtbVs7d(this), groupPermission);
						int num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (NonUniqueObjectException val)
					{
						NonUniqueObjectException message = val;
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 3:
								j7Ghpf76aYEkN5hl9Sm(etjQFV7nmRZmwtbVs7d(this));
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
								{
									num4 = 1;
								}
								continue;
							case 2:
								Logger.Warn(message);
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
								{
									num4 = 3;
								}
								continue;
							default:
								if (LSiEBj77QKlqxiGaJn3(Logger))
								{
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
									{
										num4 = 2;
									}
									continue;
								}
								goto case 3;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 9;
				default:
					throw new ArgumentNullException((string)pkpCWO7kRUmAeHpuENh(0x62C4BCE8 ^ 0x62C4945C));
				case 4:
					if (nY19177po7sC9Gdw7ss(permission, null))
					{
						goto end_IL_0012;
					}
					if (esWlKO75cr1cg7kEQyo(GetGroupPermission(group, permission)) <= 0)
					{
						GroupPermission groupPermission2 = new GroupPermission();
						vSnY9n7AhlC5OS9voFQ(groupPermission2, group);
						qSjkNC7XJoFLfYXE9p3(groupPermission2, dLpZlp7WQpC1Nf8Kgp6(permission));
						groupPermission = groupPermission2;
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 3;
					}
					break;
				case 5:
					if (group != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public virtual IEnumerable<IUserGroup> GetGroupsByPermission(Permission permission)
	{
		if (permission == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C648300 ^ 0x2C64958E));
		}
		return GetGroupsByPermissionUid(permission.Id);
	}

	public IEnumerable<IUserGroup> GetGroupsByPermissionUid(Guid permissionUid)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.permissionUid = permissionUid;
		if (_003C_003Ec__DisplayClass9_.permissionUid == Guid.Empty)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417DA91C));
		}
		IQueryable<GroupPermission> source = base.Session.Query<GroupPermission>();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(GroupPermission), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1801396866 ^ -1801390690));
		List<GroupPermission> groupPermissions = source.Where(Expression.Lambda<Func<GroupPermission, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass9_, typeof(_003C_003Ec__DisplayClass9_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ToList();
		groupPermissions = ClearGroups(groupPermissions);
		return groupPermissions.Select((GroupPermission v) => (IUserGroup)_003C_003Ec.b4XqxLpiXcoUf1ePRnI7(v)).ToList();
	}

	private List<GroupPermission> ClearGroups(IEnumerable<GroupPermission> groupPermissions)
	{
		//IL_0061: Expected O, but got Unknown
		if (groupPermissions == null)
		{
			return null;
		}
		List<GroupPermission> list = new List<GroupPermission>();
		foreach (GroupPermission groupPermission in groupPermissions)
		{
			try
			{
				if (groupPermission.Group == null || groupPermission.Group.IsNew())
				{
					RemovePermissionInternal(groupPermission);
					continue;
				}
				_ = groupPermission.Group.Name;
				list.Add(groupPermission);
			}
			catch (ObjectNotFoundException val)
			{
				ObjectNotFoundException exception = val;
				Logger.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCDF201B ^ 0xCDF08F3)), (Exception)(object)exception);
				try
				{
					RemovePermissionInternal(groupPermission);
				}
				catch (Exception exception2)
				{
					Logger.Error(exception2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71BC7C31 ^ 0x71BC5571), groupPermission.PermissionId);
				}
			}
		}
		return list;
	}

	public virtual IEnumerable<Guid> GetGroupPermissions(IUserGroup userGroup)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		_003C_003Ec__DisplayClass11_.userGroup = userGroup;
		if (_003C_003Ec__DisplayClass11_.userGroup == null)
		{
			throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x67DFA65E ^ 0x67DF8FD8));
		}
		IQueryable<GroupPermission> source = base.Session.Query<GroupPermission>();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(GroupPermission), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-566078848 ^ -566068640));
		return (from v in source.Where(Expression.Lambda<Func<GroupPermission, bool>>(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass11_, typeof(_003C_003Ec__DisplayClass11_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).ToList()
			select v.PermissionId).ToList();
	}

	[Transaction]
	public virtual void RemovePermission(IUserGroup userGroup, Permission permission)
	{
		//Discarded unreachable code: IL_0093, IL_00a2, IL_00ad, IL_0143, IL_0156, IL_0165
		int num = 2;
		List<GroupPermission>.Enumerator enumerator = default(List<GroupPermission>.Enumerator);
		GroupPermission current = default(GroupPermission);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (userGroup == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
						{
							num2 = 1;
						}
						break;
					}
					if (!(permission == null))
					{
						goto end_IL_0012;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					throw new ArgumentNullException((string)pkpCWO7kRUmAeHpuENh(-1973849202 ^ -1973855736));
				case 0:
					return;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_00b1;
							}
							goto IL_00e1;
							IL_00b1:
							while (true)
							{
								switch (num3)
								{
								case 2:
									return;
								case 3:
									break;
								default:
									goto IL_00e1;
								case 1:
									RemovePermissionInternal(current, permission);
									num3 = 3;
									continue;
								}
								break;
							}
							continue;
							IL_00e1:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
							{
								num3 = 1;
							}
							goto IL_00b1;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 3:
					throw new ArgumentNullException((string)pkpCWO7kRUmAeHpuENh(0x46F7DF98 ^ 0x46F7C916));
				}
				continue;
				end_IL_0012:
				break;
			}
			enumerator = GetGroupPermission(userGroup, permission).GetEnumerator();
			num = 4;
		}
	}

	[Transaction]
	public virtual void RemovePermission(IUserGroup userGroup)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = default(_003C_003Ec__DisplayClass13_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				_003C_003Ec__DisplayClass13_.userGroup = userGroup;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_308690af1b2f43b9a97bf91d774a6420 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
			{
				if (_003C_003Ec__DisplayClass13_.userGroup == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
					{
						num2 = 0;
					}
					break;
				}
				IQueryable<GroupPermission> source = ((ISession)etjQFV7nmRZmwtbVs7d(this)).Query<GroupPermission>();
				ParameterExpression parameterExpression = (ParameterExpression)r94Qoa7ZLAP3QLNSqdu(IoGoUG7NpAmq2BOFZpO(typeof(GroupPermission).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730081412));
				source.Where(Expression.Lambda<Func<GroupPermission, bool>>((Expression)gtpkge7ewah9vca5xMb(k9HmoJ7BhwxETaGwrQJ(parameterExpression, (MethodInfo)UfaGBN7xuBhWsq1VBkJ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field((Expression)gVtx9y7utMEQmrjKksv(_003C_003Ec__DisplayClass13_, IoGoUG7NpAmq2BOFZpO(typeof(_003C_003Ec__DisplayClass13_0).TypeHandle)), (FieldInfo)xyZbPk7mbjVrtuOqbCJ((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).ToList().ForEach(RemovePermissionInternal);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				throw new ArgumentNullException((string)pkpCWO7kRUmAeHpuENh(-731479136 ^ -731469274));
			}
		}
	}

	private void RemovePermissionInternal(GroupPermission groupPermission)
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
				RemovePermissionInternal(groupPermission, null);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void RemovePermissionInternal(GroupPermission groupPermission, Permission permission)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (GroupPermissionEventHandler != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 1:
				return;
			case 3:
				PwBN7i7LTJbdCCKxipn(etjQFV7nmRZmwtbVs7d(this), groupPermission);
				num2 = 2;
				break;
			default:
				Q5sO3K7lRYRf3bMIsub(GroupPermissionEventHandler, new GroupPermissionEventArgs(groupPermission, GroupPermissionOperation.Remove, permission));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private List<GroupPermission> GetGroupPermission(IUserGroup userGroup, Permission permission)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.permission = permission;
		_003C_003Ec__DisplayClass16_.userGroup = userGroup;
		IQueryable<GroupPermission> source = base.Session.Query<GroupPermission>();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(GroupPermission), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1687496463 ^ -1687490543));
		return source.Where(Expression.Lambda<Func<GroupPermission, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Property(Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass16_, typeof(_003C_003Ec__DisplayClass16_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), liftToNull: false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Equal(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass16_, typeof(_003C_003Ec__DisplayClass16_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), new ParameterExpression[1] { parameterExpression })).ToList();
	}

	[Transaction]
	public virtual void Clear()
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
				((ISession)etjQFV7nmRZmwtbVs7d(this)).Query<GroupPermission>().ToList().ForEach((Action<GroupPermission>)base.Session.Delete);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public GroupPermissionManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jmeetG7jbiDJm4vLeOM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fe4qv8i1drVHIgRxfNJ()
	{
		return rpCwTPiffKkySApKtr2 == null;
	}

	internal static GroupPermissionManager cNEkspizqXpr1O065h6()
	{
		return rpCwTPiffKkySApKtr2;
	}

	internal static object pkpCWO7kRUmAeHpuENh(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool nY19177po7sC9Gdw7ss(object P_0, object P_1)
	{
		return (Permission)P_0 == (Permission)P_1;
	}

	internal static int esWlKO75cr1cg7kEQyo(object P_0)
	{
		return ((List<GroupPermission>)P_0).Count;
	}

	internal static void vSnY9n7AhlC5OS9voFQ(object P_0, object P_1)
	{
		((GroupPermission)P_0).Group = (IUserGroup)P_1;
	}

	internal static Guid dLpZlp7WQpC1Nf8Kgp6(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static void qSjkNC7XJoFLfYXE9p3(object P_0, Guid value)
	{
		((GroupPermission)P_0).PermissionId = value;
	}

	internal static object etjQFV7nmRZmwtbVs7d(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static void HPCbby7iSk1EHP6pbPj(object P_0, object P_1)
	{
		((ISession)P_0).SaveOrUpdate(P_1);
	}

	internal static bool LSiEBj77QKlqxiGaJn3(object P_0)
	{
		return ((ILogger)P_0).IsWarnEnabled();
	}

	internal static void j7Ghpf76aYEkN5hl9Sm(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static void Q5sO3K7lRYRf3bMIsub(object P_0, object P_1)
	{
		((IGroupPermissionEventHandler)P_0).PostChange((GroupPermissionEventArgs)P_1);
	}

	internal static Type IoGoUG7NpAmq2BOFZpO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object r94Qoa7ZLAP3QLNSqdu(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object UfaGBN7xuBhWsq1VBkJ(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object k9HmoJ7BhwxETaGwrQJ(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object gVtx9y7utMEQmrjKksv(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object xyZbPk7mbjVrtuOqbCJ(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object gtpkge7ewah9vca5xMb(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static void PwBN7i7LTJbdCCKxipn(object P_0, object P_1)
	{
		((ISession)P_0).Delete(P_1);
	}

	internal static void jmeetG7jbiDJm4vLeOM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
