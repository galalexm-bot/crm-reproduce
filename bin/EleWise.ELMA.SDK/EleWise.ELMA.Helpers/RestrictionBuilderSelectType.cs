using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers;

public class RestrictionBuilderSelectType<T> : RestrictionBuilderBase<T>
{
	internal static object zu2ZsfhcrCCV8OhJxKiY;

	public RestrictionBuilderSelectType(Restriction restriction, RestrictionsBuilder<T> restrictionsBuilder)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(restriction, restrictionsBuilder);
	}

	public RestrictionBuilderSelectAction<T> ForType<T1>()
	{
		restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectAction<T> ForType(Type type)
	{
		restriction.ObjectType = InterfaceActivator.TypeOf(type);
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectAction<T> ForPropertyName(Type type, string propertyName)
	{
		restriction.ParentType = InterfaceActivator.TypeOf(type);
		restriction.PropertyName = propertyName;
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectAction<T> ForPropertyName<T1>(string propertyName)
	{
		restriction.ParentType = InterfaceActivator.TypeOf<T1>();
		restriction.PropertyName = propertyName;
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectAction<T> ForPropertyName<T1>(Expression<Func<T1, object>> f)
	{
		restriction.ParentType = InterfaceActivator.TypeOf<T1>();
		restriction.PropertyName = LinqUtils.NameOf(f);
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectAction<T> ForPropertyName(string propertyName)
	{
		restriction.ParentType = InterfaceActivator.TypeOf<T>();
		restriction.PropertyName = propertyName;
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectAction<T> ForPropertyName(Expression<Func<T, object>> f)
	{
		restriction.ParentType = InterfaceActivator.TypeOf<T>();
		restriction.PropertyName = LinqUtils.NameOf(f);
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectAction<T> ForAllProperties<T1>()
	{
		restriction.ParentType = InterfaceActivator.TypeOf<T1>();
		return new RestrictionBuilderSelectAction<T>(this);
	}

	public RestrictionBuilderSelectCollectionAction<T, T1> ForCollectionsOfType<T1>() where T1 : class
	{
		restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
		restriction.RuleType = RuleType.Collection;
		return new RestrictionBuilderSelectCollectionAction<T, T1>(this);
	}

	public RestrictionBuilderSelectCollectionAction<T, T1> ForCollection<T1>(string propertyName) where T1 : class
	{
		restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
		restriction.PropertyName = propertyName;
		restriction.RuleType = RuleType.Collection;
		return new RestrictionBuilderSelectCollectionAction<T, T1>(this);
	}

	public RestrictionBuilderSelectCollectionAction<T, T1> ForCollection<T1>(Expression<Func<T, ICollection<T1>>> f) where T1 : class
	{
		restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
		restriction.PropertyName = LinqUtils.NameOf(f);
		restriction.RuleType = RuleType.Collection;
		return new RestrictionBuilderSelectCollectionAction<T, T1>(this);
	}

	public RestrictionBuilderSelectCollectionAction<T, object> ForAllCollections()
	{
		restriction.RuleType = RuleType.Collection;
		return new RestrictionBuilderSelectCollectionAction<T, object>(this);
	}

	public void NHibernate(bool nHibernate = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				restrictionsBuilder.restrictions.nHibernate = nHibernate;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				restrictionsBuilder.restrictions.Remove(restriction);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void CloneRecursive(bool cloneRecursive = true)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				restrictionsBuilder.restrictions.Remove(restriction);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				restrictionsBuilder.restrictions.CloneRecursive = cloneRecursive;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool F50fj5hcgZEUvIvIQEg0()
	{
		return zu2ZsfhcrCCV8OhJxKiY == null;
	}

	internal static object mNVdrShc51Ab15fINKFM()
	{
		return zu2ZsfhcrCCV8OhJxKiY;
	}
}
