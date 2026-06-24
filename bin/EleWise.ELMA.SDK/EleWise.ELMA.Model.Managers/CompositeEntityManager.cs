using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public abstract class CompositeEntityManager<T, IdT> : IEntityManager<T, IdT>, IEntityManager<T>, IEntityManager, ICompositeEntityManager where T : class, ICompositeEntity<IdT>
{
	private static object Cle3dkhQ6JOnXvBFj9u4;

	public abstract T Create();

	public virtual T Load(IdT id)
	{
		return LoadOrNull(id) ?? throw new ObjectNotFoundException(typeof(T).FullName, id);
	}

	public abstract T LoadOrNull(IdT id);

	public abstract T LoadOrCreate(IdT id);

	public abstract T LoadOrCreate(Guid uid);

	public virtual T Load(Guid uid)
	{
		return LoadOrNull(uid) ?? throw new ObjectNotFoundException(typeof(T).FullName, uid);
	}

	public virtual T LoadOrNull(Guid uid)
	{
		throw new NotImplementedException();
	}

	public virtual ActionCheckResult CanSave(T obj)
	{
		return ActionCheckResult.True;
	}

	public virtual void Save(T obj)
	{
		foreach (IEntity compositeEntity in obj.GetCompositeEntities())
		{
			GetPartialManager(compositeEntity).Save(compositeEntity);
		}
	}

	public virtual ActionCheckResult CanDelete(T obj)
	{
		return ActionCheckResult.True;
	}

	public virtual void Delete(T obj)
	{
		foreach (IEntity compositeEntity in obj.GetCompositeEntities())
		{
			GetPartialManager(compositeEntity).Delete(compositeEntity);
		}
	}

	public virtual void DeleteAll()
	{
		throw new NotImplementedException();
	}

	public virtual void Refresh(T obj)
	{
		foreach (IEntity compositeEntity in obj.GetCompositeEntities())
		{
			GetPartialManager(compositeEntity).Refresh(compositeEntity);
		}
	}

	public virtual void Refresh(T obj, LockMode mode)
	{
		foreach (IEntity compositeEntity in obj.GetCompositeEntities())
		{
			GetPartialManager(compositeEntity).Refresh(compositeEntity, mode);
		}
	}

	public bool IsNew(object obj)
	{
		return IsNew((T)obj);
	}

	public bool IsNew(T obj)
	{
		return obj.GetCompositeEntities().Any((IEntity e) => e.IsNew());
	}

	public bool IsDirty(object obj)
	{
		return IsDirty((T)obj);
	}

	public bool IsDirty(object obj, object originalState)
	{
		return IsDirty((T)obj, originalState);
	}

	public Guid[] GetDirtyPropertyUids(object obj)
	{
		return GetDirtyPropertyUids((T)obj);
	}

	public Guid[] GetDirtyPropertyUids(object obj, object originalState)
	{
		return GetDirtyPropertyUids((T)obj, originalState);
	}

	public virtual object GetCurrentState(object obj)
	{
		return GetCurrentState((T)obj);
	}

	public virtual bool IsDirty(T obj)
	{
		return IsDirty(obj, null);
	}

	public virtual bool IsDirty(T obj, object originalState)
	{
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0.originalStateDict = originalState as Dictionary<string, object>;
		return obj.GetCompositeEntities().Any(delegate(IEntity e)
		{
			//Discarded unreachable code: IL_0039, IL_0048
			int num = 4;
			object value = default(object);
			string key = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 5:
						return EntityHelper.GetEntityManager(e.GetType().GetTypeWithoutProxy()).IsDirty(e, value);
					case 1:
						key = e.GetType().GetTypeWithoutProxy().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710651424) + e.GetId();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						CS_0024_003C_003E8__locals0.originalStateDict.TryGetValue(key, out value);
						num2 = 5;
						continue;
					case 4:
						break;
					case 3:
						if (CS_0024_003C_003E8__locals0.originalStateDict == null)
						{
							num2 = 2;
							continue;
						}
						goto case 1;
					}
					break;
				}
				value = null;
				num = 3;
			}
		});
	}

	public virtual Guid[] GetDirtyPropertyUids(T obj)
	{
		return GetDirtyPropertyUids(obj, null);
	}

	public virtual Guid[] GetDirtyPropertyUids(T obj, object originalState)
	{
		List<Guid> list = new List<Guid>();
		Dictionary<string, object> dictionary = originalState as Dictionary<string, object>;
		foreach (IEntity compositeEntity in obj.GetCompositeEntities())
		{
			object value = null;
			if (dictionary != null)
			{
				string key = compositeEntity.GetType().GetTypeWithoutProxy().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882317752) + compositeEntity.GetId();
				dictionary.TryGetValue(key, out value);
			}
			Guid[] dirtyPropertyUids = EntityHelper.GetEntityManager(compositeEntity.GetType().GetTypeWithoutProxy()).GetDirtyPropertyUids(compositeEntity, value);
			if (dirtyPropertyUids != null)
			{
				list.AddRange(dirtyPropertyUids);
			}
		}
		return list.ToArray();
	}

	public virtual object GetCurrentState(T obj)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (IEntity compositeEntity in obj.GetCompositeEntities())
		{
			string key = compositeEntity.GetType().GetTypeWithoutProxy().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541662045) + compositeEntity.GetId();
			IEntityManager entityManager = EntityHelper.GetEntityManager(compositeEntity.GetType().GetTypeWithoutProxy());
			dictionary[key] = entityManager.GetCurrentState(compositeEntity);
		}
		return dictionary;
	}

	public virtual ICollection<T> FindAll()
	{
		throw new NotImplementedException();
	}

	public virtual ICollection<T> FindByIdArray(IdT[] idArray)
	{
		throw new NotImplementedException();
	}

	public virtual ICollection<T> Find(FetchOptions fetchOptions)
	{
		throw new NotImplementedException();
	}

	public virtual ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions)
	{
		throw new NotImplementedException();
	}

	public virtual IEnumerable<TItem> Find<TItem>(IEntityFilter filter, FetchOptions fetchOptions)
	{
		throw new NotImplementedException();
	}

	public ICollection<T> Find(Expression<Func<T, bool>> condition)
	{
		throw new NotImplementedException();
	}

	public ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition)
	{
		throw new NotImplementedException();
	}

	public ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions)
	{
		throw new NotImplementedException();
	}

	public ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition, FetchOptions fetchOptions)
	{
		throw new NotImplementedException();
	}

	public ICollection<T> Find(string eqlFilter)
	{
		throw new NotImplementedException();
	}

	public virtual void Delete(string query)
	{
		throw new NotImplementedException();
	}

	public virtual long Count()
	{
		throw new NotImplementedException();
	}

	public virtual long Count(IEntityFilter filter)
	{
		throw new NotImplementedException();
	}

	public virtual void CheckFilter(IEntityFilter filter)
	{
		throw new NotImplementedException();
	}

	public virtual ICollection<PT> Projection<PT>(string propertyName)
	{
		throw new NotImplementedException();
	}

	public ExportRuleList ExportRules()
	{
		return null ?? throw new NotImplementedException();
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
		return FindByIdArray(idArray.Cast<IdT>().ToArray());
	}

	object IEntityManager.Create()
	{
		return Create();
	}

	object IEntityManager.Load(object id)
	{
		return Load((IdT)id);
	}

	object IEntityManager.LoadOrCreate(object id)
	{
		return LoadOrCreate((IdT)id);
	}

	object IEntityManager.LoadOrCreate(Guid uid)
	{
		return LoadOrCreate(uid);
	}

	object IEntityManager.LoadOrNull(object id)
	{
		return LoadOrNull((IdT)id);
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
		return CanSave((T)obj);
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
				Save((T)obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	ActionCheckResult IEntityManager.CanDelete(object obj)
	{
		return CanDelete((T)obj);
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
				Delete((T)obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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
			case 1:
				Refresh((T)obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
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
			case 1:
				Refresh((T)obj, mode);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	IEnumerable IEntityManager.FindAll()
	{
		return FindAll();
	}

	IEnumerable IEntityManager.FindByIdArray(object[] idArray)
	{
		return FindByIdArray(idArray.Cast<IdT>().ToArray());
	}

	IEnumerable IEntityManager.Find(FetchOptions fetchOptions)
	{
		return Find(fetchOptions);
	}

	IEnumerable IEntityManager.Find(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return Find(filter, fetchOptions);
	}

	public void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		throw new NotImplementedException();
	}

	public DetachedCriteria CreateDetachedCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		throw new NotImplementedException();
	}

	public void FilterDetachedCriteria(DetachedCriteria detachedCriteria, FetchOptions fetchOptions, Type type, IEntityFilter filter = null)
	{
		throw new NotImplementedException();
	}

	public virtual SecurityException CreateSecurityException(string text, object id)
	{
		return new SecurityException(text);
	}

	public virtual IEntityManager GetPartialManager(Type entityType)
	{
		return ModelHelper.GetEntityManager(entityType);
	}

	protected IEntityManager GetPartialManager(IEntity entity)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(entity, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317752716));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ModelHelper.GetEntityManager(entity.GetType().GetTypeWithoutProxy());
			}
		}
	}

	protected CompositeEntityManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MwRLwlhQHwjFio5BwY4y()
	{
		return Cle3dkhQ6JOnXvBFj9u4 == null;
	}

	internal static object a8i9AwhQA4LGnV4v55bJ()
	{
		return Cle3dkhQ6JOnXvBFj9u4;
	}
}
