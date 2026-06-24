using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Model.Managers;

[Component]
public abstract class AbstractNHEntityManager<T, IdT> : NHManager, IEntityManager<T, IdT>, IEntityManager<T>, IEntityManager where T : IEntity<IdT>
{
	private bool? cacheEnabled;

	private static object somXQphQmwQNRiK6SXdl;

	public static IEntityManager<T, IdT> Instance => Locator.GetServiceNotNull<IEntityManager<T, IdT>>();

	protected virtual bool CacheEnabled
	{
		get
		{
			int num = 1;
			int num2 = num;
			CacheEntityAttribute attribute = default(CacheEntityAttribute);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return cacheEnabled.Value;
				case 1:
					if (!cacheEnabled.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				default:
					attribute = AttributeHelper<CacheEntityAttribute>.GetAttribute(typeof(T), inherited: true);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					cacheEnabled = attribute?.Enabled ?? false;
					num2 = 3;
					break;
				}
			}
		}
	}

	protected virtual bool IsSoftDeletable => typeof(T).GetInterface(typeof(ISoftDeletable).FullName) != null;

	[NotNull]
	public abstract T Create();

	public abstract bool IsNew(T obj);

	public abstract bool IsDirty(T obj);

	public abstract bool IsDirty(T obj, object originalState);

	public abstract Guid[] GetDirtyPropertyUids(T obj);

	public abstract Guid[] GetDirtyPropertyUids(T obj, object originalState);

	public abstract object GetCurrentState(T obj);

	[NotNull]
	public abstract T Load(IdT id);

	[CanBeNull]
	public abstract T LoadOrNull(IdT id);

	[NotNull]
	public abstract T Load(Guid uid);

	[CanBeNull]
	public abstract T LoadOrNull(Guid uid);

	[NotNull]
	public abstract T LoadOrCreate(IdT id);

	[NotNull]
	public abstract T LoadOrCreate(Guid uid);

	public abstract ActionCheckResult CanSave(T obj);

	public abstract void Save(T obj);

	public abstract ActionCheckResult CanDelete(T obj);

	public abstract void Delete(T obj);

	public abstract void Delete(string query);

	public abstract void DeleteAll();

	public abstract void Refresh(T obj);

	public abstract void Refresh(T obj, LockMode mode);

	public abstract ICollection<T> FindAll();

	public abstract ICollection<T> FindByIdArray(IdT[] idArray);

	public abstract ICollection<T> FindAll(bool cacheble);

	public abstract ICollection<T> Find(FetchOptions fetchOptions);

	public abstract ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions);

	public abstract ICollection<T> Find(Expression<Func<T, bool>> condition);

	public abstract ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition);

	public abstract ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions);

	public abstract ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition, FetchOptions fetchOptions);

	public abstract ICollection<T> Find(string eqlFilter);

	public abstract ICollection<T> Find(string eqlFilter, FetchOptions fetchOptions);

	public abstract long Count();

	public abstract long Count(IEntityFilter filter);

	public abstract void CheckFilter(IEntityFilter filter);

	public abstract ICollection<TProperty> Projection<TProperty>(string propertyName);

	public abstract void SetupFilter(ICriteria criteria, IEntityFilter filter);

	public abstract DetachedCriteria CreateDetachedCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null);

	public abstract void FilterDetachedCriteria(DetachedCriteria detachedCriteria, FetchOptions fetchOptions, Type type, IEntityFilter filter = null);

	public virtual SecurityException CreateSecurityException(string text, object id)
	{
		return new SecurityException(text, InterfaceActivator.TypeOf<T>(), id.ToString());
	}

	public virtual bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null)
	{
		return true;
	}

	T IEntityManager<T>.Load(object id)
	{
		return Load((IdT)id);
	}

	T IEntityManager<T>.LoadOrNull(object id)
	{
		return LoadOrNull((IdT)id);
	}

	T IEntityManager<T>.LoadOrCreate(object id)
	{
		return LoadOrCreate((IdT)id);
	}

	ICollection<T> IEntityManager<T>.FindByIdArray(object[] idArray)
	{
		return ((IEntityManager)this).FindByIdArray(idArray).Cast<T>().ToList();
	}

	object IEntityManager.Create()
	{
		return Create();
	}

	object IEntityManager.Load(object id)
	{
		return Load((IdT)Convert.ChangeType(id, typeof(IdT)));
	}

	object IEntityManager.LoadOrNull(object id)
	{
		return LoadOrNull((IdT)Convert.ChangeType(id, typeof(IdT)));
	}

	object IEntityManager.LoadOrCreate(object id)
	{
		return LoadOrCreate((IdT)Convert.ChangeType(id, typeof(IdT)));
	}

	object IEntityManager.LoadOrCreate(Guid uid)
	{
		return LoadOrCreate(uid);
	}

	object IEntityManager.Load(Guid uid)
	{
		return Load(uid);
	}

	object IEntityManager.LoadOrNull(Guid uid)
	{
		return LoadOrNull(uid);
	}

	ActionCheckResult IEntityManager.CanSave(object obj)
	{
		return CanSave((T)obj.CastAsRealType());
	}

	void IEntityManager.Save(object obj)
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
				Save((T)obj.CastAsRealType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	ActionCheckResult IEntityManager.CanDelete(object obj)
	{
		return CanDelete((T)obj.CastAsRealType());
	}

	void IEntityManager.Delete(object obj)
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
				Delete((T)obj.CastAsRealType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IEntityManager.Delete(string query)
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
				Delete(query);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	void IEntityManager.Refresh(object obj)
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
				Refresh((T)obj.CastAsRealType());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void IEntityManager.Refresh(object obj, LockMode mode)
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
				Refresh((T)obj.CastAsRealType(), mode);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	bool IEntityManager.IsNew(object obj)
	{
		return IsNew((T)obj.CastAsRealType());
	}

	bool IEntityManager.IsDirty(object obj)
	{
		return IsDirty((T)obj.CastAsRealType());
	}

	bool IEntityManager.IsDirty(object obj, object originalState)
	{
		return IsDirty((T)obj.CastAsRealType(), originalState);
	}

	Guid[] IEntityManager.GetDirtyPropertyUids(object obj)
	{
		return GetDirtyPropertyUids((T)obj.CastAsRealType());
	}

	Guid[] IEntityManager.GetDirtyPropertyUids(object obj, object originalState)
	{
		return GetDirtyPropertyUids((T)obj.CastAsRealType(), originalState);
	}

	object IEntityManager.GetCurrentState(object obj)
	{
		return GetCurrentState((T)obj.CastAsRealType());
	}

	IEnumerable IEntityManager.FindAll()
	{
		return FindAll();
	}

	IEnumerable IEntityManager.FindByIdArray(object[] idArray)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return FindByIdArray(idArray.Cast<IdT>().ToArray());
			case 1:
				return FindAll();
			case 2:
				if (idArray == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	IEnumerable IEntityManager.Find(FetchOptions fetchOptions)
	{
		return Find(fetchOptions);
	}

	IEnumerable IEntityManager.Find(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return Find(filter, fetchOptions);
	}

	IEnumerable<TItem> IEntityManager.Find<TItem>(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return (IEnumerable<TItem>)Find(filter, fetchOptions);
	}

	protected T Unproxy(T target)
	{
		return (T)base.Session.GetSessionImplementation().get_PersistenceContext().Unproxy((object)target);
	}

	public abstract ExportRuleList ExportRules();

	protected AbstractNHEntityManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool fF2ky3hQyI15SSkYfEIV()
	{
		return somXQphQmwQNRiK6SXdl == null;
	}

	internal static object okX52xhQM8EZYujI4MmF()
	{
		return somXQphQmwQNRiK6SXdl;
	}
}
