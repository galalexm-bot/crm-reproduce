using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

public abstract class ExpressionPermissionBase<ET, PT> : IInstanceExpressionPermission where PT : class, IInstanceExpressionPermissionHolder, IEntity
{
	protected class PropertyExpressionDescriptor : IPropertyExpressionDescriptor
	{
		private readonly Expression<Func<ET, object>> expression;

		private readonly string name;

		private readonly Func<ET, object> accessor;

		private readonly Func<object, object> accessorViaObject;

		private readonly bool allowChief;

		internal static object wKxxMbpitphyxWr6OqIO;

		public virtual string Name => name;

		public Func<object, object> Accessor => accessorViaObject;

		public bool AllowChief => allowChief;

		public PropertyExpressionDescriptor(Expression<Func<ET, object>> expression, bool allowChief = false)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			this.expression = expression;
			name = expression.ToString();
			accessor = expression.Compile();
			accessorViaObject = (object o) => accessor((ET)o);
			this.allowChief = allowChief;
		}

		internal static bool KFrafdpihnwGncP5eiyE()
		{
			return wKxxMbpitphyxWr6OqIO == null;
		}

		internal static object dR7wMIpiOtBtrYMFm0Kh()
		{
			return wKxxMbpitphyxWr6OqIO;
		}
	}

	protected class PropertyExpressionDescriptorWithInstanceUid : PropertyExpressionDescriptor, IPropertyExpressionDescriptorWithInstanceUid, IPropertyExpressionDescriptor
	{
		private readonly Func<ET, string> accessorGetInstanceUid;

		private readonly Func<object, string> accessorViaUid;

		private readonly PermissionRoleType roleType;

		private static object kvpr1ipiqCkEtpxXFiKN;

		public PermissionRoleType RoleType => roleType;

		public PropertyExpressionDescriptorWithInstanceUid(Expression<Func<ET, object>> expression, PermissionRoleType roleType, bool allowChief = false)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector(expression, allowChief);
			this.roleType = roleType;
		}

		public PropertyExpressionDescriptorWithInstanceUid(Expression<Func<ET, object>> expression, Expression<Func<ET, string>> expressionGetInstanceUid, PermissionRoleType roleType, bool allowChief = false)
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector(expression, allowChief);
			this.roleType = roleType;
			accessorGetInstanceUid = expressionGetInstanceUid.Compile();
			accessorViaUid = (object o) => accessorGetInstanceUid((ET)o);
		}

		public string GetExpressionName(object obj)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (accessorViaUid != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
						{
							num2 = 0;
						}
						break;
					}
					return Name;
				default:
					return Name + accessorViaUid(obj);
				}
			}
		}

		internal static bool IQ6TOSpicmd2yRrZ0eG6()
		{
			return kvpr1ipiqCkEtpxXFiKN == null;
		}

		internal static object KS4NggpiGP8JiLi1KIau()
		{
			return kvpr1ipiqCkEtpxXFiKN;
		}
	}

	private PropertyExpressionDescriptor[] acessProperties;

	internal static object pBcZxE7hQO1Qut1OgHq;

	public virtual Type EntityType => typeof(ET);

	public Type PermissionType => typeof(PT);

	public virtual IPropertyExpressionDescriptor[] AccessExpressions
	{
		get
		{
			//Discarded unreachable code: IL_005a, IL_0069
			int num = 1;
			int num2 = num;
			IPropertyExpressionDescriptor[] result = default(IPropertyExpressionDescriptor[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return result;
				default:
					result = acessProperties;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					acessProperties = AccesspropertiesExpressions();
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					if (acessProperties != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}
	}

	public virtual string PermissionsTable => InterfaceActivator.TypeOf<PT>().Name;

	protected abstract PropertyExpressionDescriptor[] AccesspropertiesExpressions();

	public virtual IEnumerable GetPermissionCollection(object target)
	{
		return GetPermissionPersistenceCollection((ET)target);
	}

	protected abstract ICollection<PT> GetPermissionPersistenceCollection(ET target);

	protected ExpressionPermissionBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MLCa337OFBK6CjlWwsR()
	{
		return pBcZxE7hQO1Qut1OgHq == null;
	}

	internal static object eu8udu7qcKoa7NfXVIV()
	{
		return pBcZxE7hQO1Qut1OgHq;
	}
}
