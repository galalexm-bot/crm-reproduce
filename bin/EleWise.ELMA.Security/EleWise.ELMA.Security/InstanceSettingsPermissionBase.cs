using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public abstract class InstanceSettingsPermissionBase<ET, PT> : IInstanceSettingsPermission where ET : class where PT : class, IInstanceSettingsPermissionHolder
{
	private class PermissionsCollection<PT> : ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>, IEnumerable where PT : class, IInstanceSettingsPermissionHolder
	{
		private readonly ICollection<PT> target;

		private static object HBQJfMpiFeptMGVLBnED;

		public int Count => target.Count;

		public bool IsReadOnly => target.IsReadOnly;

		public PermissionsCollection(ICollection<PT> target)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			this.target = target;
		}

		public IEnumerator<IInstanceSettingsPermissionHolder> GetEnumerator()
		{
			return target.GetEnumerator();
		}

		public void Add(IInstanceSettingsPermissionHolder item)
		{
			int num = 5;
			int num2 = num;
			PT val = default(PT);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (val == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
						{
							num2 = 2;
						}
						break;
					}
					target.Add(val);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 4:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1130812004 ^ 0x43664D8E));
				case 5:
					if (item != null)
					{
						val = item as PT;
						num2 = 2;
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
				{
					ICollection<PT> collection = target;
					InstanceOf<PT> instanceOf = new InstanceOf<PT>();
					instanceOf.New.TypeRoleId = item.TypeRoleId;
					instanceOf.New.PermissionId = item.PermissionId;
					instanceOf.New.Target = item.Target;
					instanceOf.New.Assigned = item.Assigned;
					collection.Add(instanceOf.New);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 0:
					return;
				}
			}
		}

		public void Clear()
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
					target.Clear();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool Contains(IInstanceSettingsPermissionHolder item)
		{
			return target.Contains((PT)item);
		}

		public void CopyTo(IInstanceSettingsPermissionHolder[] array, int arrayIndex)
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
					target.Cast<IInstanceSettingsPermissionHolder>().ToList().CopyTo(array, arrayIndex);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public bool Remove(IInstanceSettingsPermissionHolder item)
		{
			return target.Remove((PT)item);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return target.GetEnumerator();
		}

		internal static bool i5U9gmpi0cll2bbdO1vN()
		{
			return HBQJfMpiFeptMGVLBnED == null;
		}

		internal static object bxgdUUpiEk7IhYh1Fw3s()
		{
			return HBQJfMpiFeptMGVLBnED;
		}
	}

	private readonly Expression<Func<PT, ET>> targetExpression;

	private readonly string targetPropertyName;

	private static object yvi7MU7cDc9PatcKxqY;

	public virtual Type EntityType => InterfaceActivator.TypeOf<ET>();

	public virtual bool Filtering => true;

	public virtual string TargetPropetyName => targetPropertyName;

	public virtual Type PermissionHolderType => InterfaceActivator.TypeOf<PT>();

	public virtual Permission AdminPermission => null;

	protected ISecurityService SecurityService => Locator.GetService<ISecurityService>();

	protected InstanceSettingsPermissionBase(Expression<Func<PT, ET>> targetExpression)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		this.targetExpression = targetExpression;
		targetPropertyName = LinqUtils.NameOf(targetExpression);
	}

	public virtual bool CanGrandPermissions(IUser user, object target)
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(AdminPermission == null))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return true;
			case 1:
				return SecurityService.HasPermission(user, AdminPermission);
			}
		}
	}

	public virtual ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		return null;
	}

	public bool IsSystemRole(Guid permissionRoleTypeId, IEntity permissionRole, object target)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass15_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass15_.permissionRoleTypeId = permissionRoleTypeId;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass15_.permissionRole = permissionRole;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass15_.target = target;
				num2 = 5;
				break;
			case 3:
				_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				return ComponentManager.Current.GetExtensionPoints<ISystemRolePermissions>().Where(_003C_003Ec__DisplayClass15_._003CIsSystemRole_003Eb__0).Any(_003C_003Ec__DisplayClass15_._003CIsSystemRole_003Eb__1);
			}
		}
	}

	public virtual bool IsSystemDefaultPermission(Permission permissionToCheck, Guid permissionRoleTypeId, IEntity permissionRole, object target)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass16_.permissionRole = permissionRole;
				num2 = 5;
				break;
			case 6:
				return ComponentManager.Current.GetExtensionPoints<ISystemRolePermissions>().Where(_003C_003Ec__DisplayClass16_._003CIsSystemDefaultPermission_003Eb__0).Any(_003C_003Ec__DisplayClass16_._003CIsSystemDefaultPermission_003Eb__1);
			default:
				_003C_003Ec__DisplayClass16_.permissionRoleTypeId = permissionRoleTypeId;
				num2 = 3;
				break;
			case 4:
				_003C_003Ec__DisplayClass16_.permissionToCheck = permissionToCheck;
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass16_.target = target;
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass16_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool CanGrandToElement(Permission[] elementPermission, Permission[] userPermission, Permission permissionToCheck, Guid permissionRoleTypeId, IEntity permissionRole, object target)
	{
		//Discarded unreachable code: IL_0111, IL_0120, IL_0142, IL_0151
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
				num2 = 5;
				break;
			case 2:
				return true;
			case 1:
				return userPermission.Any(_003C_003Ec__DisplayClass17_._003CCanGrandToElement_003Eb__0);
			case 4:
				return false;
			case 8:
				if (userPermission != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 9:
				if (permissionRole != null)
				{
					num2 = 7;
					break;
				}
				goto case 8;
			case 7:
				if (target != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 3:
				if (!(permissionRoleTypeId != Guid.Empty))
				{
					num2 = 8;
					break;
				}
				goto case 9;
			default:
				if (IsSystemDefaultPermission(_003C_003Ec__DisplayClass17_.permissionToCheck, permissionRoleTypeId, permissionRole, target))
				{
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 8;
			case 5:
				_003C_003Ec__DisplayClass17_.permissionToCheck = permissionToCheck;
				num2 = 3;
				break;
			}
		}
	}

	public virtual ICollection<IInstanceSettingsPermissionHolder> GetPermissionCollection(object target)
	{
		if (!(target is ET target2))
		{
			throw new InvalidOperationException();
		}
		return new PermissionsCollection<PT>(GetPermissionHolderCollection(target2));
	}

	protected abstract ICollection<PT> GetPermissionHolderCollection(ET target);

	internal static bool SgdtdY7Gu1Y3L7dRhYb()
	{
		return yvi7MU7cDc9PatcKxqY == null;
	}

	internal static object aQRFYv7F35MGcnJ3rDS()
	{
		return yvi7MU7cDc9PatcKxqY;
	}
}
