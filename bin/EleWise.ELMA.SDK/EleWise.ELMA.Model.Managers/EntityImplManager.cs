using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Model.Managers;

public class EntityImplManager<T, TIntf, IdT> : IEntityManager<T, IdT>, IEntityManager<T>, IEntityManager where T : TIntf where TIntf : IEntity<IdT>
{
	private IEntityManager<TIntf, IdT> manager;

	private static object cbLsBLhQq4ccC6agKptk;

	private IEntityManager<TIntf, IdT> Manager => manager ?? (manager = Locator.GetServiceNotNull<IEntityManager<TIntf, IdT>>());

	[PublicApiMember]
	public T Create()
	{
		return (T)(object)Manager.Create();
	}

	[PublicApiMember]
	public bool IsNew(T obj)
	{
		return Manager.IsNew((TIntf)(object)obj);
	}

	[PublicApiMember]
	public bool IsDirty(T obj)
	{
		return Manager.IsDirty((TIntf)(object)obj);
	}

	public bool IsDirty(T obj, object originalState)
	{
		return Manager.IsDirty((TIntf)(object)obj, originalState);
	}

	public Guid[] GetDirtyPropertyUids(T obj)
	{
		return Manager.GetDirtyPropertyUids((TIntf)(object)obj);
	}

	public Guid[] GetDirtyPropertyUids(T obj, object originalState)
	{
		return Manager.GetDirtyPropertyUids((TIntf)(object)obj, originalState);
	}

	public object GetCurrentState(T obj)
	{
		return Manager.GetCurrentState((TIntf)(object)obj);
	}

	[PublicApiMember]
	public T Load(IdT id)
	{
		return (T)(object)Manager.Load(id);
	}

	[PublicApiMember]
	public T LoadOrNull(IdT id)
	{
		return (T)(object)Manager.LoadOrNull(id);
	}

	[PublicApiMember]
	public T LoadOrCreate(IdT id)
	{
		return (T)(object)Manager.LoadOrCreate(id);
	}

	[PublicApiMember]
	public T LoadOrCreate(Guid uid)
	{
		return (T)(object)Manager.LoadOrCreate(uid);
	}

	[PublicApiMember]
	public T Load(Guid uid)
	{
		return (T)(object)Manager.Load(uid);
	}

	[PublicApiMember]
	public T LoadOrNull(Guid uid)
	{
		return (T)(object)Manager.LoadOrNull(uid);
	}

	public virtual ActionCheckResult CanSave(T obj)
	{
		return ActionCheckResult.True;
	}

	[PublicApiMember]
	public void Save(T obj)
	{
		Manager.Save((TIntf)(object)obj);
	}

	public virtual ActionCheckResult CanDelete(T obj)
	{
		return ActionCheckResult.True;
	}

	[PublicApiMember]
	public void Delete(T obj)
	{
		Manager.Delete((TIntf)(object)obj);
	}

	public void DeleteAll()
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
				Manager.DeleteAll();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public void Refresh(T obj)
	{
		Manager.Refresh((TIntf)(object)obj);
	}

	public void Refresh(T obj, LockMode mode)
	{
		Manager.Refresh((TIntf)(object)obj, mode);
	}

	public ICollection<T> FindAll()
	{
		return Manager.FindAll().Cast<T>().ToList();
	}

	[PublicApiMember]
	[NotNull]
	public ICollection<T> FindByIdArray(IdT[] idArray)
	{
		return Manager.FindByIdArray(idArray).Cast<T>().ToList();
	}

	[PublicApiMember]
	[NotNull]
	public ICollection<T> Find(FetchOptions fetchOptions)
	{
		return Manager.Find(fetchOptions).Cast<T>().ToList();
	}

	[PublicApiMember]
	[NotNull]
	public ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return Manager.Find(filter, fetchOptions).Cast<T>().ToList();
	}

	public ICollection<T> Find(Expression<Func<T, bool>> condition)
	{
		return Manager.Find(condition);
	}

	public ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition)
	{
		return Manager.Find(condition);
	}

	public ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions)
	{
		return Manager.Find(condition, fetchOptions);
	}

	public ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition, FetchOptions fetchOptions)
	{
		return Manager.Find(condition, fetchOptions);
	}

	[NotNull]
	[PublicApiMember]
	public ICollection<T> Find(string eqlFilter)
	{
		return Manager.Find(eqlFilter).Cast<T>().ToList();
	}

	[PublicApiMember]
	public long Count()
	{
		return Manager.Count();
	}

	[PublicApiMember]
	public long Count(IEntityFilter filter)
	{
		return Manager.Count(filter);
	}

	[PublicApiMember]
	public void CheckFilter(IEntityFilter filter)
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
				Manager.CheckFilter(filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ExportRuleList ExportRules()
	{
		return null ?? throw new NotImplementedException();
	}

	public bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null)
	{
		return Manager.ExistPropertiesForFastSearch(metadata, filter);
	}

	T IEntityManager<T>.Load(object id)
	{
		return (T)(object)Manager.Load(id);
	}

	T IEntityManager<T>.LoadOrNull(object id)
	{
		return (T)(object)Manager.LoadOrNull(id);
	}

	T IEntityManager<T>.LoadOrCreate(object id)
	{
		return (T)(object)Manager.LoadOrCreate(id);
	}

	ICollection<T> IEntityManager<T>.FindByIdArray(object[] idArray)
	{
		return Manager.FindByIdArray(idArray).Cast<T>().ToList();
	}

	ActionCheckResult IEntityManager<T>.CanSave(T obj)
	{
		return Manager.CanSave((TIntf)(object)obj);
	}

	ActionCheckResult IEntityManager<T>.CanDelete(T obj)
	{
		return Manager.CanDelete((TIntf)(object)obj);
	}

	object IEntityManager.Create()
	{
		return ((IEntityManager)Manager).Create();
	}

	bool IEntityManager.IsNew(object obj)
	{
		return Manager.IsNew(obj);
	}

	bool IEntityManager.IsDirty(object obj)
	{
		return Manager.IsDirty(obj);
	}

	bool IEntityManager.IsDirty(object obj, object originalState)
	{
		return Manager.IsDirty(obj, originalState);
	}

	Guid[] IEntityManager.GetDirtyPropertyUids(object obj)
	{
		return Manager.GetDirtyPropertyUids(obj);
	}

	Guid[] IEntityManager.GetDirtyPropertyUids(object obj, object originalState)
	{
		return Manager.GetDirtyPropertyUids(obj, originalState);
	}

	object IEntityManager.GetCurrentState(object obj)
	{
		return Manager.GetCurrentState(obj);
	}

	object IEntityManager.Load(object id)
	{
		return ((IEntityManager)Manager).Load(id);
	}

	object IEntityManager.LoadOrNull(object id)
	{
		return ((IEntityManager)Manager).LoadOrNull(id);
	}

	object IEntityManager.LoadOrCreate(object id)
	{
		return ((IEntityManager)Manager).LoadOrCreate(id);
	}

	object IEntityManager.LoadOrCreate(Guid uid)
	{
		return ((IEntityManager)Manager).LoadOrCreate(uid);
	}

	object IEntityManager.Load(Guid uid)
	{
		return ((IEntityManager)Manager).Load(uid);
	}

	object IEntityManager.LoadOrNull(Guid uid)
	{
		return ((IEntityManager)Manager).LoadOrNull(uid);
	}

	ActionCheckResult IEntityManager.CanSave(object obj)
	{
		return Manager.CanSave(obj);
	}

	public void Save(object obj)
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
				Manager.Save(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	ActionCheckResult IEntityManager.CanDelete(object obj)
	{
		return Manager.CanDelete(obj);
	}

	public void Delete(object obj)
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
				Manager.Delete(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Delete(string query)
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
				Manager.Delete(query);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Refresh(object obj)
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
				Manager.Refresh(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Refresh(object obj, LockMode mode)
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
				Manager.Refresh(obj, mode);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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
		return ((IEntityManager)Manager).FindAll();
	}

	IEnumerable IEntityManager.FindByIdArray(object[] idArray)
	{
		return ((IEntityManager)Manager).FindByIdArray(idArray);
	}

	IEnumerable IEntityManager.Find(FetchOptions fetchOptions)
	{
		return ((IEntityManager)Manager).Find(fetchOptions);
	}

	IEnumerable IEntityManager.Find(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return ((IEntityManager)Manager).Find(filter, fetchOptions);
	}

	public ICollection<PT> Projection<PT>(string propertyName)
	{
		return Manager.Projection<PT>(propertyName);
	}

	IEnumerable<T1> IEntityManager.Find<T1>(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return Manager.Find<T1>(filter, fetchOptions);
	}

	public void SetupFilter(ICriteria criteria, IEntityFilter filter)
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
				Manager.SetupFilter(criteria, filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DetachedCriteria CreateDetachedCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		return Manager.CreateDetachedCriteria(fetchOptions, type, alias, filter);
	}

	public void FilterDetachedCriteria(DetachedCriteria detachedCriteria, FetchOptions fetchOptions, Type type, IEntityFilter filter = null)
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
				Manager.FilterDetachedCriteria(detachedCriteria, fetchOptions, type, filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public SecurityException CreateSecurityException(string text, object id)
	{
		return Manager.CreateSecurityException(text, id);
	}

	public EntityImplManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hK1YRvhQKUgceRvy5LMR()
	{
		return cbLsBLhQq4ccC6agKptk == null;
	}

	internal static object Ntpv6uhQXXrcXpbptNGo()
	{
		return cbLsBLhQq4ccC6agKptk;
	}
}
