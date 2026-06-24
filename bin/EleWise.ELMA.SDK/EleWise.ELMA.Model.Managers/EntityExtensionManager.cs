using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public class EntityExtensionManager<TBase, T, IdT> : EntityExtensionManager<TBase, T, IdT, IEntityManager<TBase, IdT>> where TBase : class, IEntity<IdT> where T : class, TBase
{
	private static object wedq6RhfgGFJ7cQiWXc6;

	public EntityExtensionManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool cn80jEhf5su6mqssdn9s()
	{
		return wedq6RhfgGFJ7cQiWXc6 == null;
	}

	internal static object znSd1khfjdwY13F8eLUW()
	{
		return wedq6RhfgGFJ7cQiWXc6;
	}
}
[Component]
public class EntityExtensionManager<TBase, T, IdT, TBaseManager> : NHManager, IEntityExtensionManager<TBase, T, IdT, TBaseManager>, IEntityExtensionManager<TBase, T, IdT>, IEntityManager<T, IdT>, IEntityManager<T>, IEntityManager, IEntityExtensionManager where TBase : class, IEntity<IdT> where T : class, TBase where TBaseManager : class, IEntityManager<TBase, IdT>
{
	private TBaseManager manager;

	private static object m2M86thfYSMFKVr9uP7J;

	public TBaseManager Manager
	{
		get
		{
			if (manager == null)
			{
				manager = Locator.GetServiceNotNull<TBaseManager>();
			}
			return manager;
		}
	}

	IEntityManager<TBase, IdT> IEntityExtensionManager<TBase, T, IdT>.Manager => Manager;

	protected Type ImplementationType => InterfaceActivator.TypeOf<T>();

	private EntityManager<TBase, IdT> ManagerImpl => (EntityManager<TBase, IdT>)(object)Manager;

	[NotNull]
	public IEntityActionHandler ActionHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CActionHandler_003Ek__BackingField;
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
					_003CActionHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual void Preprocess(AuditableCancelEventArgs e)
	{
		//Discarded unreachable code: IL_00eb
		int num = 3;
		int num2 = num;
		string name = default(string);
		MethodInfo method = default(MethodInfo);
		Type[] types = default(Type[]);
		List<object> list = default(List<object>);
		object result = default(object);
		object[] array = default(object[]);
		while (true)
		{
			switch (num2)
			{
			case 13:
				return;
			case 3:
				name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875985911) + e.Method.Name;
				num2 = 2;
				break;
			case 7:
				e.Cancel = true;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 8;
				}
				break;
			default:
				method = GetType().GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic, null, types, null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 12;
				}
				break;
			case 6:
				return;
			case 12:
				if (!(method == null))
				{
					list = new List<object>();
					num2 = 10;
				}
				else
				{
					num2 = 13;
				}
				break;
			case 10:
				if (e.Params != null)
				{
					num2 = 5;
					break;
				}
				goto case 9;
			case 4:
				result = method.Invoke(this, array);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 11;
				}
				break;
			case 5:
				list.AddRange(e.Params.Values);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				array = list.ToArray();
				num2 = 4;
				break;
			case 14:
				e.Result = result;
				num2 = 7;
				break;
			case 9:
				list.Add(false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				if (!(bool)array[array.Length - 1])
				{
					num2 = 6;
					break;
				}
				goto case 14;
			case 8:
				return;
			case 2:
				types = (from pi in e.Method.GetParameters()
					select pi.ParameterType).Concat(new Type[1] { typeof(bool).MakeByRefType() }).ToArray();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void Postprocess(AuditableEventArgs e)
	{
		//Discarded unreachable code: IL_01c2, IL_02a2, IL_02b1, IL_0323
		int num = 4;
		MethodInfo methodInfo = default(MethodInfo);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		object result = default(object);
		object[] parameters = default(object[]);
		List<object> list = default(List<object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					methodInfo = GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic).Where(_003C_003Ec__DisplayClass5_._003CPostprocess_003Eb__0).FirstOrDefault();
					num2 = 9;
					continue;
				case 20:
					if (!(_003C_003Ec__DisplayClass5_.e.Method.ReturnType != typeof(void)))
					{
						return;
					}
					goto end_IL_0012;
				case 2:
					_003C_003Ec__DisplayClass5_.e.Result = result;
					num2 = 14;
					continue;
				case 11:
					parameters = list.ToArray();
					num2 = 13;
					continue;
				case 7:
					if (!(methodInfo.ReturnType != null))
					{
						num2 = 10;
						continue;
					}
					break;
				case 1:
					if (_003C_003Ec__DisplayClass5_.e.Method.ReturnType != null)
					{
						num2 = 20;
						continue;
					}
					return;
				case 17:
					_003C_003Ec__DisplayClass5_.pCount = _003C_003Ec__DisplayClass5_.e.Method.GetParameters().Length;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					if (!_003C_003Ec__DisplayClass5_.e.Method.ReturnType.IsAssignableFrom(methodInfo.ReturnType))
					{
						num2 = 18;
						continue;
					}
					goto case 2;
				case 4:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 3;
					continue;
				case 10:
					return;
				default:
					list.Add(_003C_003Ec__DisplayClass5_.e.Result);
					num2 = 11;
					continue;
				case 19:
					list.AddRange(_003C_003Ec__DisplayClass5_.e.Params.Values);
					num2 = 16;
					continue;
				case 9:
					if (methodInfo == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 12;
						}
					}
					else
					{
						list = new List<object>();
						num2 = 5;
					}
					continue;
				case 13:
					result = methodInfo.Invoke(this, parameters);
					num2 = 7;
					continue;
				case 8:
				case 16:
					if (methodInfo.GetParameters().Length == _003C_003Ec__DisplayClass5_.pCount + 1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 12:
					return;
				case 15:
					_003C_003Ec__DisplayClass5_._003C_003E4__this = this;
					num2 = 21;
					continue;
				case 5:
					if (_003C_003Ec__DisplayClass5_.e.Params == null)
					{
						num2 = 8;
						continue;
					}
					goto case 19;
				case 21:
					_003C_003Ec__DisplayClass5_.methodName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F4D9D) + _003C_003Ec__DisplayClass5_.e.Method.Name;
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 17;
					}
					continue;
				case 18:
					return;
				case 14:
					return;
				case 3:
					_003C_003Ec__DisplayClass5_.e = e;
					num2 = 15;
					continue;
				case 23:
					break;
				}
				if (!(methodInfo.ReturnType != typeof(void)))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public virtual int OrderBy(AuditableEventArgs e)
	{
		return 0;
	}

	[PublicApiMember]
	public T Create()
	{
		return (T)Manager.Create();
	}

	[PublicApiMember]
	public bool IsNew(T obj)
	{
		return Manager.IsNew((TBase)obj);
	}

	[PublicApiMember]
	public bool IsDirty(T obj)
	{
		return Manager.IsDirty((TBase)obj);
	}

	public bool IsDirty(T obj, object originalState)
	{
		return Manager.IsDirty((TBase)obj, originalState);
	}

	public Guid[] GetDirtyPropertyUids(T obj)
	{
		return Manager.GetDirtyPropertyUids((TBase)obj);
	}

	public Guid[] GetDirtyPropertyUids(T obj, object originalState)
	{
		return Manager.GetDirtyPropertyUids((TBase)obj, originalState);
	}

	public object GetCurrentState(T obj)
	{
		return Manager.GetCurrentState((TBase)obj);
	}

	[PublicApiMember]
	public T Load(IdT id)
	{
		return (T)Manager.Load(id);
	}

	[PublicApiMember]
	public T LoadOrNull(IdT id)
	{
		return (T)Manager.LoadOrNull(id);
	}

	[PublicApiMember]
	public T LoadOrCreate(IdT id)
	{
		return (T)Manager.LoadOrCreate(id);
	}

	[PublicApiMember]
	public T LoadOrCreate(Guid uid)
	{
		return (T)Manager.LoadOrCreate(uid);
	}

	[PublicApiMember]
	public T Load(Guid uid)
	{
		return (T)Manager.Load(uid);
	}

	[PublicApiMember]
	public T LoadOrNull(Guid uid)
	{
		return (T)Manager.LoadOrNull(uid);
	}

	[PublicApiMember]
	public void Save(T obj)
	{
		Manager.Save((TBase)obj);
	}

	[PublicApiMember]
	public void Delete(T obj)
	{
		Manager.Delete((TBase)obj);
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
			case 1:
				Manager.DeleteAll();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiMember]
	public void Refresh(T obj)
	{
		Manager.Refresh((TBase)obj);
	}

	public void Refresh(T obj, LockMode mode)
	{
		Manager.Refresh((TBase)obj, mode);
	}

	public ICollection<T> FindAll()
	{
		return Manager.FindAll().Cast<T>().ToList();
	}

	[PublicApiMember]
	public ICollection<T> FindByIdArray(IdT[] idArray)
	{
		return Manager.FindByIdArray(idArray).Cast<T>().ToList();
	}

	[PublicApiMember]
	public ICollection<T> Find(FetchOptions fetchOptions)
	{
		return Manager.Find(fetchOptions).Cast<T>().ToList();
	}

	[PublicApiMember]
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
	public bool Exists()
	{
		return Manager.Exists();
	}

	[PublicApiMember]
	public bool Exists(IEntityFilter filter)
	{
		return Manager.Exists(filter);
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
			case 1:
				Manager.CheckFilter(filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual ExportRuleList ExportRules()
	{
		return new ExportRuleList();
	}

	public bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null)
	{
		return Manager.ExistPropertiesForFastSearch(metadata, filter);
	}

	T IEntityManager<T>.Load(object id)
	{
		return (T)Manager.Load(id);
	}

	T IEntityManager<T>.LoadOrNull(object id)
	{
		return (T)Manager.LoadOrNull(id);
	}

	T IEntityManager<T>.LoadOrCreate(object id)
	{
		return (T)Manager.LoadOrCreate(id);
	}

	ICollection<T> IEntityManager<T>.FindByIdArray(object[] idArray)
	{
		return Manager.FindByIdArray(idArray).Cast<T>().ToList();
	}

	ActionCheckResult IEntityManager<T>.CanSave(T obj)
	{
		return Manager.CanSave((TBase)obj);
	}

	ActionCheckResult IEntityManager<T>.CanDelete(T obj)
	{
		return Manager.CanDelete((TBase)obj);
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

	bool IEntityManager.IsDirty(object obj, object originalStatej)
	{
		return Manager.IsDirty(obj, originalStatej);
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
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
			case 1:
				Manager.SetupFilter(criteria, filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
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
			case 1:
				Manager.FilterDetachedCriteria(detachedCriteria, fetchOptions, type, filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public SecurityException CreateSecurityException(string text, object id)
	{
		return Manager.CreateSecurityException(text, id);
	}

	protected ICriteria CreateCriteria()
	{
		return ManagerImpl.CreateCriteria();
	}

	protected ICriteria CreateCriteria(FetchOptions fetchOptions, Type type, string alias = null)
	{
		return ManagerImpl.CreateCriteria(fetchOptions, type, alias);
	}

	protected DetachedCriteria CreateDetachedCriteria(FetchOptions fetchOptions, Type type, string alias = null)
	{
		return ManagerImpl.CreateDetachedCriteria(fetchOptions, type, alias);
	}

	protected virtual T OnPreCreate(ref bool cancel)
	{
		return null;
	}

	protected virtual T OnCreate(T obj)
	{
		return obj;
	}

	protected virtual T OnPreLoad(IdT id, ref bool cancel)
	{
		return null;
	}

	protected virtual T OnLoad(IdT id, T obj)
	{
		return obj;
	}

	protected virtual T OnPreLoadOrNull(IdT id, ref bool cancel)
	{
		return null;
	}

	protected virtual T OnLoadOrNull(IdT id, T obj)
	{
		return obj;
	}

	protected void OnPreSave(TBase obj, ref bool cancel)
	{
		OnPreSave((T)obj, ref cancel);
	}

	protected virtual void OnPreSave(T obj, ref bool cancel)
	{
	}

	protected virtual void OnSave(T obj)
	{
	}

	protected virtual void OnPreDelete(T obj, ref bool cancel)
	{
	}

	protected virtual void OnDelete(T obj)
	{
	}

	protected virtual void OnPreDelete(string query, ref bool cancel)
	{
	}

	protected virtual void OnDelete(string query)
	{
	}

	protected virtual void OnPreRefresh(T obj, ref bool cancel)
	{
	}

	protected virtual void OnRefresh(T obj)
	{
	}

	protected virtual void OnPreSetupFilter(ICriteria criteria, IEntityFilter filter, ref bool cancel)
	{
	}

	protected virtual void OnSetupFilter(ICriteria criteria, IEntityFilter filter)
	{
	}

	protected virtual void OnPreSetupFastSearchFilter(ICriteria criteria, IEntityFilter filter, ref bool cancel)
	{
	}

	protected virtual void OnSetupFastSearchFilter(ICriteria criteria, IEntityFilter filter)
	{
	}

	private bool IsAssignableParameters(ParameterInfo[] sourceParameters, ParameterInfo[] targetParameters)
	{
		//Discarded unreachable code: IL_0075, IL_0084, IL_0094, IL_00a3, IL_00b3, IL_015d, IL_016c, IL_01a7
		int num = 5;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (sourceParameters == null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 9;
				case 2:
					return false;
				case 11:
					num3++;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 6;
					}
					break;
				case 8:
					if (targetParameters[num3].ParameterType.IsAssignableFrom(sourceParameters[num3].ParameterType))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 4:
				case 7:
				case 10:
					return false;
				case 12:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (num3 >= sourceParameters.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 8;
				case 1:
					return true;
				case 9:
					if (targetParameters == null)
					{
						num2 = 7;
						break;
					}
					goto case 3;
				case 3:
					if (sourceParameters.Length <= targetParameters.Length)
					{
						goto end_IL_0012;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	public EntityExtensionManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool dVuBXMhfLwEAC9fqg7MA()
	{
		return m2M86thfYSMFKVr9uP7J == null;
	}

	internal static object e3uhAWhfUKs8W2xLEjB2()
	{
		return m2M86thfYSMFKVr9uP7J;
	}
}
