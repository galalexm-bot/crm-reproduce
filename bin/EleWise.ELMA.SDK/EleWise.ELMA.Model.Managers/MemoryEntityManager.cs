using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Managers;

public class MemoryEntityManager<T, IdT> : AbstractNHEntityManager<T, IdT> where T : IEntity<IdT>
{
	protected class EntityEntry
	{
		private static object IKij9xCghmhALW24KmAr;

		public T Entity { get; private set; }

		public DateTime LastAccessTime
		{
			[CompilerGenerated]
			get
			{
				return _003CLastAccessTime_003Ek__BackingField;
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
						_003CLastAccessTime_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

		public EntityEntry(T entity)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			Entity = entity;
			LastAccessTime = DateTime.Now;
		}

		internal static bool kjQ9WACgGlHLFTcWCllV()
		{
			return IKij9xCghmhALW24KmAr == null;
		}

		internal static object vjRodHCgERdjXDDPpVUx()
		{
			return IKij9xCghmhALW24KmAr;
		}
	}

	private PropertyMetadata _uidPropertyMetadata;

	private PropertyInfo _uidProperty;

	private object _idSync;

	private bool? isTablePart;

	private static object hP2k7JhG4cUlPIRVDS6I;

	protected bool IsTablePart
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return isTablePart.Value;
				case 1:
					if (!isTablePart.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				default:
					isTablePart = InterfaceActivator.LoadMetadata<T>() is ITablePartMetadata;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public MemoryEntityManager()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		_idSync = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				_uidProperty = typeof(T).GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D80EC));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				return;
			}
			_uidPropertyMetadata = ((ClassMetadata)MetadataLoader.LoadMetadata(typeof(T))).Properties.FirstOrDefault(delegate(PropertyMetadata p)
			{
				//Discarded unreachable code: IL_006d, IL_007c
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 1:
						if (!(p.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751169934)))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						return p.TypeUid == GuidDescriptor.UID;
					default:
						return false;
					}
				}
			});
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
			{
				num = 2;
			}
		}
	}

	public override T Create()
	{
		return Activator.CreateInstance<T>();
	}

	public override bool IsNew(T obj)
	{
		return true;
	}

	public override bool IsDirty(T obj)
	{
		return false;
	}

	public override bool IsDirty(T obj, object originalState)
	{
		return false;
	}

	public override Guid[] GetDirtyPropertyUids(T obj)
	{
		return null;
	}

	public override Guid[] GetDirtyPropertyUids(T obj, object originalState)
	{
		return null;
	}

	public override object GetCurrentState(T obj)
	{
		return null;
	}

	public override T Load(IdT id)
	{
		return LoadOrNull(id) ?? throw new ObjectNotFoundException(typeof(T).AssemblyQualifiedName, id);
	}

	public override T LoadOrNull(IdT id)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.id = id;
		List<EntityEntry> entries = GetEntries();
		EntityEntry entityEntry = entries.FirstOrDefault((EntityEntry e) => e.Entity.Id.Equals(CS_0024_003C_003E8__locals0.id));
		if (entityEntry == null && CreateOnLoad(CS_0024_003C_003E8__locals0.id))
		{
			T entity = Create();
			entity.Id = CS_0024_003C_003E8__locals0.id;
			entityEntry = new EntityEntry(entity);
			entries.Add(entityEntry);
		}
		if (entityEntry != null)
		{
			entityEntry.LastAccessTime = DateTime.Now;
			return entityEntry.Entity;
		}
		return default(T);
	}

	public override T Load(Guid uid)
	{
		return LoadOrNull(uid) ?? throw new ObjectNotFoundException(typeof(T).AssemblyQualifiedName, uid);
	}

	public override T LoadOrNull(Guid uid)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.uid = uid;
		if (_uidProperty == null)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811966852), typeof(T).AssemblyQualifiedName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289725960)));
		}
		EntityEntry entityEntry = GetEntries().FirstOrDefault((EntityEntry e) => (Guid)CS_0024_003C_003E8__locals0._003C_003E4__this._uidProperty.GetValue(e.Entity, null) == CS_0024_003C_003E8__locals0.uid);
		if (entityEntry != null)
		{
			entityEntry.LastAccessTime = DateTime.Now;
			return entityEntry.Entity;
		}
		return default(T);
	}

	public override ActionCheckResult CanSave(T obj)
	{
		return ActionCheckResult.True;
	}

	public override T LoadOrCreate(IdT id)
	{
		T val = LoadOrNull(id);
		if (val == null)
		{
			val = Create();
			val.Id = id;
			GetEntries().Add(new EntityEntry(val));
		}
		return val;
	}

	public override T LoadOrCreate(Guid uid)
	{
		T val = LoadOrNull(uid);
		if (val == null)
		{
			val = Create();
			_uidProperty.SetValue(val, uid, null);
			GetEntries().Add(new EntityEntry(val));
		}
		return val;
	}

	public override void Save(T obj)
	{
	}

	public override ActionCheckResult CanDelete(T obj)
	{
		return ActionCheckResult.True;
	}

	public override void Delete(T obj)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		CS_0024_003C_003E8__locals0.obj = obj;
		if (CS_0024_003C_003E8__locals0.obj == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F919A));
		}
		List<EntityEntry> entries = GetEntries();
		EntityEntry entityEntry = entries.FirstOrDefault((EntityEntry e) => e.Entity.Equals(CS_0024_003C_003E8__locals0.obj));
		if (entityEntry != null)
		{
			entries.Remove(entityEntry);
		}
	}

	public override void Delete(string query)
	{
		throw new NotImplementedException();
	}

	public override void DeleteAll()
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
				GetEntries().Clear();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Refresh(T obj)
	{
	}

	public override void Refresh(T obj, LockMode mode)
	{
	}

	public override ICollection<T> FindAll()
	{
		return Unwrap(GetEntries());
	}

	public override ICollection<T> FindByIdArray(IdT[] idArray)
	{
		if (idArray == null)
		{
			return FindAll();
		}
		new List<EntityEntry>();
		return (from id in idArray
			select LoadOrNull(id) into e
			where e != null
			select e).ToArray();
	}

	public override ICollection<T> FindAll(bool cacheble)
	{
		return FindAll();
	}

	public override ICollection<T> Find(FetchOptions fetchOptions)
	{
		return Find((IEntityFilter)null, fetchOptions);
	}

	public override ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions)
	{
		return FindAll();
	}

	public override ICollection<T> Find(Expression<Func<T, bool>> condition)
	{
		_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0();
		CS_0024_003C_003E8__locals0.condition = condition;
		return Unwrap(from e in GetEntries()
			where CS_0024_003C_003E8__locals0.condition.Compile()(e.Entity)
			select e);
	}

	public override ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition)
	{
		_003C_003Ec__DisplayClass28_0<TResult> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass28_0<TResult>();
		CS_0024_003C_003E8__locals0.condition = condition;
		return Unwrap(from e in GetEntries()
			where e.Entity is TResult && CS_0024_003C_003E8__locals0.condition.Compile()((TResult)(object)e.Entity)
			select e).Cast<TResult>().ToList();
	}

	public override ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions)
	{
		return Find(condition);
	}

	public override ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition, FetchOptions fetchOptions)
	{
		return Find(condition);
	}

	public override ICollection<T> Find(string eqlFilter)
	{
		return Find(new Filter
		{
			Query = eqlFilter
		}, FetchOptions.All);
	}

	public override ICollection<T> Find(string eqlFilter, FetchOptions fetchOptions)
	{
		return Find(new Filter
		{
			Query = eqlFilter
		}, fetchOptions);
	}

	public override long Count()
	{
		return Count(null);
	}

	public override long Count(IEntityFilter filter)
	{
		return GetEntries().Count;
	}

	public override void CheckFilter(IEntityFilter filter)
	{
	}

	public override ICollection<TProperty> Projection<TProperty>(string propertyName)
	{
		throw new NotImplementedException();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
	}

	public override DetachedCriteria CreateDetachedCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null)
	{
		throw new NotImplementedException();
	}

	public override void FilterDetachedCriteria(DetachedCriteria detachedCriteria, FetchOptions fetchOptions, Type type, IEntityFilter filter = null)
	{
		throw new NotImplementedException();
	}

	public override ExportRuleList ExportRules()
	{
		throw new NotImplementedException();
	}

	protected ICollection<T> Unwrap(IEnumerable<EntityEntry> collection)
	{
		if (collection == null)
		{
			return null;
		}
		foreach (EntityEntry item in collection)
		{
			item.LastAccessTime = DateTime.Now;
		}
		return collection.Select((EntityEntry e) => e.Entity).ToList();
	}

	protected virtual bool CreateOnLoad(IdT id)
	{
		if (IsTablePart)
		{
			return id as long? < 0;
		}
		return false;
	}

	private List<EntityEntry> GetEntries()
	{
		return ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957619138) + typeof(T).AssemblyQualifiedName, () => new List<EntityEntry>());
	}

	internal static bool PLQTrNhG64vkIDtwmqbD()
	{
		return hP2k7JhG4cUlPIRVDS6I == null;
	}

	internal static object Ifj5mYhGHP6HdTfpV6r0()
	{
		return hP2k7JhG4cUlPIRVDS6I;
	}
}
