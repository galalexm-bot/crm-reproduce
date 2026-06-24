using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

[Component]
internal class EntityInstancePermissionsListener : IUnitOfWorkEventListener
{
	private readonly MethodInfo syncPermissions;

	private static EntityInstancePermissionsListener V0g13eaXxirU7OX2Hl1;

	public IEnumerable<IInstanceExpressionPermission> Providers { get; set; }

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
				case 0:
					return;
				case 1:
					_003CLogger_003Ek__BackingField = value;
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

	public EntityInstancePermissionsListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XcLfaGa709pAIN1AWaG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			syncPermissions = DnU0nna6bjyYXnve9ID(this).GetMethod((string)z5Cex4alZAt4vXL4jFE(-724676315 ^ -724689109), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
			{
				num = 0;
			}
		}
	}

	private void ProcessInstancePermissions(Type eventEntityType, object target)
	{
		//Discarded unreachable code: IL_002f, IL_0039, IL_00bd, IL_00cc, IL_025f, IL_027e, IL_02ae, IL_02bd
		int num = 2;
		int num2 = num;
		IEnumerator<IInstanceExpressionPermission> enumerator = default(IEnumerator<IInstanceExpressionPermission>);
		MethodInfo methodInfo = default(MethodInfo);
		IInstanceExpressionPermission current = default(IInstanceExpressionPermission);
		IDynamicExpressionPermission dynamicExpressionPermission = default(IDynamicExpressionPermission);
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!qLKloPaLXyiHUuPun3U(enumerator))
						{
							num3 = 2;
							goto IL_003d;
						}
						goto IL_0216;
						IL_003d:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 4:
							case 9:
								methodInfo = (MethodInfo)i9PDHgaB55hYmUVnGlY(syncPermissions, new Type[2]
								{
									current.EntityType,
									t9khv4axvBB20rasuvW(current)
								});
								num3 = 2;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
								{
									num3 = 5;
								}
								continue;
							case 8:
								if (dynamicExpressionPermission != null)
								{
									num3 = 11;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc == 0)
									{
										num3 = 5;
									}
									continue;
								}
								break;
							case 11:
								S5FNr6amnPKt9TAmDjZ(methodInfo, this, new object[3]
								{
									target,
									Mke78VaetLo1s3m1moX(dynamicExpressionPermission, target),
									enumerable
								});
								num3 = 7;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 != 0)
								{
									num3 = 2;
								}
								continue;
							case 6:
								S5FNr6amnPKt9TAmDjZ(methodInfo, this, new object[3] { target, current.AccessExpressions, enumerable });
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
								{
									num3 = 10;
								}
								continue;
							case 5:
								enumerable = (IEnumerable)Hxspn3aug78YOYc0NZC(current, target);
								num3 = 6;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
								{
									num3 = 6;
								}
								continue;
							case 10:
								dynamicExpressionPermission = current as IDynamicExpressionPermission;
								num3 = 8;
								continue;
							case 1:
								if (iqCFMGaZGvXEEesBtlM(eventEntityType, zV0UxvaN9bKRQtEOKZQ(current)))
								{
									num3 = 8;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
									{
										num3 = 9;
									}
									continue;
								}
								goto default;
							case 7:
								break;
							default:
								if (eventEntityType.IsInheritOrSame(zV0UxvaN9bKRQtEOKZQ(current)))
								{
									num3 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 != 0)
									{
										num3 = 4;
									}
									continue;
								}
								break;
							case 3:
								goto IL_0216;
							}
							break;
						}
						continue;
						IL_0216:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
						{
							num3 = 1;
						}
						goto IL_003d;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 == 0)
						{
							num4 = 1;
						}
						goto IL_0263;
					}
					goto IL_028c;
					IL_028c:
					KenDmTajL1qdsGk7nHN(enumerator);
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
					{
						num4 = 0;
					}
					goto IL_0263;
					IL_0263:
					switch (num4)
					{
					default:
						goto end_IL_023e;
					case 1:
						goto end_IL_023e;
					case 2:
						break;
					case 0:
						goto end_IL_023e;
					}
					goto IL_028c;
					end_IL_023e:;
				}
			case 2:
				enumerator = Providers.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void SyncPermissions<ET, PT>(ET target, IPropertyExpressionDescriptor[] expressions, ICollection<PT> permissions) where ET : IEntity<long> where PT : IInstanceExpressionPermissionHolder
	{
		_003C_003Ec__DisplayClass11_0<ET, PT> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0<ET, PT>();
		CS_0024_003C_003E8__locals0.permissions = permissions;
		if (Logger.IsDebugEnabled())
		{
			Logger.Debug(string.Concat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104680817), typeof(ET).Name, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46F7DF98 ^ 0x46F791CC), target.GetId(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x416A5E3C ^ 0x416A7AC6), typeof(PT).Name));
		}
		foreach (IPropertyExpressionDescriptor propertyExpressionDescriptor in expressions)
		{
			_003C_003Ec__DisplayClass11_1<ET, PT> CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass11_1<ET, PT>();
			Func<object, object> accessor = propertyExpressionDescriptor.Accessor;
			CS_0024_003C_003E8__locals1.expressionName = ((propertyExpressionDescriptor is IPropertyExpressionDescriptorWithInstanceUid) ? ((IPropertyExpressionDescriptorWithInstanceUid)propertyExpressionDescriptor).GetExpressionName(target) : propertyExpressionDescriptor.Name);
			object obj = accessor(target);
			if (obj == null)
			{
				CS_0024_003C_003E8__locals0.permissions.Where((PT p) => p.TypeRole == CS_0024_003C_003E8__locals1.expressionName).ToList().ForEach(delegate(PT a)
				{
					CS_0024_003C_003E8__locals0.permissions.Remove(a);
				});
				continue;
			}
			if (obj is EleWise.ELMA.Security.Models.IUser)
			{
				UpdatePermissions(new EleWise.ELMA.Security.Models.IUser[1] { (EleWise.ELMA.Security.Models.IUser)obj }, target, CS_0024_003C_003E8__locals1.expressionName, CS_0024_003C_003E8__locals0.permissions, propertyExpressionDescriptor);
				continue;
			}
			if (obj is IUserGroup)
			{
				UpdatePermissions(new IUserGroup[1] { (IUserGroup)obj }, target, CS_0024_003C_003E8__locals1.expressionName, CS_0024_003C_003E8__locals0.permissions, propertyExpressionDescriptor);
				continue;
			}
			if (obj is IOrganizationItem)
			{
				UpdatePermissions(new IOrganizationItem[1] { (IOrganizationItem)obj }, target, CS_0024_003C_003E8__locals1.expressionName, CS_0024_003C_003E8__locals0.permissions, propertyExpressionDescriptor);
				continue;
			}
			if (obj is IEnumerable<EleWise.ELMA.Security.Models.IUser>)
			{
				UpdatePermissions((IEnumerable<EleWise.ELMA.Security.Models.IUser>)obj, target, CS_0024_003C_003E8__locals1.expressionName, CS_0024_003C_003E8__locals0.permissions, propertyExpressionDescriptor);
				continue;
			}
			if (obj is IEnumerable<IUserGroup>)
			{
				UpdatePermissions((IEnumerable<IUserGroup>)obj, target, CS_0024_003C_003E8__locals1.expressionName, CS_0024_003C_003E8__locals0.permissions, propertyExpressionDescriptor);
				continue;
			}
			if (obj is IEnumerable<IOrganizationItem>)
			{
				UpdatePermissions((IEnumerable<IOrganizationItem>)obj, target, CS_0024_003C_003E8__locals1.expressionName, CS_0024_003C_003E8__locals0.permissions, propertyExpressionDescriptor);
				continue;
			}
			throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x32A45635 ^ 0x32A41869), obj.GetType()));
		}
	}

	private void UpdatePermissions<PT>(IEnumerable<IEntity<long>> value, IEntity<long> target, string expressionName, ICollection<PT> permissions, IPropertyExpressionDescriptor expression) where PT : IInstanceExpressionPermissionHolder
	{
		_003C_003Ec__DisplayClass12_0<PT> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0<PT>();
		CS_0024_003C_003E8__locals0.expressionName = expressionName;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		PT[] array = permissions.Where((PT p) => p.TypeRole == CS_0024_003C_003E8__locals0.expressionName).ToArray();
		PT[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			_003C_003Ec__DisplayClass12_1<PT> _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_1<PT>();
			_003C_003Ec__DisplayClass12_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			_003C_003Ec__DisplayClass12_.pc = array2[i];
			_003C_003Ec__DisplayClass12_2<PT> CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass12_2<PT>();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass12_;
			CS_0024_003C_003E8__locals1.secExpSetIdHolder = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.pc as ISecurityExpressionSetIdHolder;
			if (CS_0024_003C_003E8__locals1.secExpSetIdHolder != null && !value.Any((IEntity<long> s) => CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.GetItemMask(s) == CS_0024_003C_003E8__locals1.secExpSetIdHolder.UserSecuritySetCacheId))
			{
				permissions.Remove(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.pc);
			}
			else if (CS_0024_003C_003E8__locals1.secExpSetIdHolder == null && !value.Any((IEntity<long> s) => object.Equals(s, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.pc.User)))
			{
				permissions.Remove(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.pc);
			}
		}
		using IEnumerator<IEntity<long>> enumerator = value.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass12_3<PT> CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass12_3<PT>();
			CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals3 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals2.item = enumerator.Current;
			if (!array.Any((PT pc) => (pc is ISecurityExpressionSetIdHolder) ? (((ISecurityExpressionSetIdHolder)(object)pc).UserSecuritySetCacheId == CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals3._003C_003E4__this.GetItemMask(CS_0024_003C_003E8__locals2.item)) : object.Equals(pc.User, CS_0024_003C_003E8__locals2.item)))
			{
				AddPermission(CS_0024_003C_003E8__locals2.item, target, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals3.expressionName, expression.AllowChief, permissions);
				if (expression.AllowChief && !(expression is IPropertyExpressionDescriptorWithInstanceUid))
				{
					AddPermission(CS_0024_003C_003E8__locals2.item, target, CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals3.expressionName, allowChief: false, permissions);
				}
			}
		}
	}

	private void AddPermission<PT>(IEntity<long> item, IEntity<long> target, string expressionName, bool allowChief, ICollection<PT> permissions) where PT : IInstanceExpressionPermissionHolder
	{
		PT val = InterfaceActivator.Create<PT>();
		val.Target = target;
		if (item is EleWise.ELMA.Security.Models.IUser user)
		{
			val.User = user;
		}
		val.TypeRole = expressionName;
		val.AllowChief = allowChief;
		if ((object)val is ISecurityExpressionSetIdHolder securityExpressionSetIdHolder)
		{
			securityExpressionSetIdHolder.UserSecuritySetCacheId = GetItemMask(item);
		}
		permissions.Add(val);
	}

	private long? GetItemMask(IEntity<long> entity)
	{
		if (entity is IUserGroup)
		{
			return UserSecuritySetHelper.GetGroupMask(entity.Id);
		}
		if (entity is IOrganizationItem)
		{
			return UserSecuritySetHelper.GetOrganizationItemMask(entity.Id);
		}
		if (entity is EleWise.ELMA.Security.Models.IUser)
		{
			return UserSecuritySetHelper.GetUserMask(entity.Id);
		}
		return null;
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
		foreach (object entity in entities)
		{
			ProcessInstancePermissions(entity.GetType(), entity);
		}
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	internal static bool Uu1rxdan5PynfdWXOqW()
	{
		return V0g13eaXxirU7OX2Hl1 == null;
	}

	internal static EntityInstancePermissionsListener b7Ci68ai7gc8eOicwGB()
	{
		return V0g13eaXxirU7OX2Hl1;
	}

	internal static void XcLfaGa709pAIN1AWaG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static Type DnU0nna6bjyYXnve9ID(object P_0)
	{
		return P_0.GetType();
	}

	internal static object z5Cex4alZAt4vXL4jFE(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type zV0UxvaN9bKRQtEOKZQ(object P_0)
	{
		return ((IInstanceExpressionPermission)P_0).EntityType;
	}

	internal static bool iqCFMGaZGvXEEesBtlM(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type t9khv4axvBB20rasuvW(object P_0)
	{
		return ((IInstanceExpressionPermission)P_0).PermissionType;
	}

	internal static object i9PDHgaB55hYmUVnGlY(object P_0, object P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod((Type[])P_1);
	}

	internal static object Hxspn3aug78YOYc0NZC(object P_0, object P_1)
	{
		return ((IInstanceExpressionPermission)P_0).GetPermissionCollection(P_1);
	}

	internal static object S5FNr6amnPKt9TAmDjZ(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static object Mke78VaetLo1s3m1moX(object P_0, object P_1)
	{
		return ((IDynamicExpressionPermission)P_0).GetPropertyDescriptors(P_1);
	}

	internal static bool qLKloPaLXyiHUuPun3U(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void KenDmTajL1qdsGk7nHN(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
