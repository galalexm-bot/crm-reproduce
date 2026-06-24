using System;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
public class EntityHolder<TId, TEntity> where TEntity : class, IEntity<TId>
{
	private TId id;

	private bool isNull;

	private static object fqQCmXhZcSLJKZrkkDVO;

	public TId Id
	{
		get
		{
			return id;
		}
		set
		{
			id = value;
		}
	}

	public virtual TEntity Object
	{
		get
		{
			if (isNull)
			{
				return null;
			}
			string name = (CacheEnabled ? GetCacheKey(Id) : string.Empty);
			if (CacheEnabled && ContextVars.TryGetValue<TEntity>(name, out var value))
			{
				return value;
			}
			value = EntityManager.Load(id) as TEntity;
			if (CacheEnabled)
			{
				ContextVars.Set(name, value);
			}
			return value;
		}
		set
		{
			SetEntity(value);
		}
	}

	protected IEntityManager EntityManager => ModelHelper.GetEntityManager(typeof(TEntity));

	protected virtual bool CacheEnabled => true;

	public EntityHolder(TId id)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.id = id;
	}

	public EntityHolder(TEntity entity)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		SetEntity(entity);
	}

	private string GetCacheKey(TId id)
	{
		return typeof(TEntity).FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A778D73) + Id;
	}

	private void SetEntity(TEntity value)
	{
		if (value == null)
		{
			isNull = true;
			return;
		}
		isNull = false;
		id = value.Id;
		if (value != null && CacheEnabled)
		{
			ContextVars.Set(GetCacheKey(value.Id), value);
		}
	}

	internal static bool G2j4f3hZz9nYKc3GDhRJ()
	{
		return fqQCmXhZcSLJKZrkkDVO == null;
	}

	internal static object bFUObkhuFKyF4hv8GtNX()
	{
		return fqQCmXhZcSLJKZrkkDVO;
	}
}
