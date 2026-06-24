using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Logging;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Metadata;
using Orchard.Logging;
using Orchard.Utility.Extensions;

namespace Orchard.Data;

public class Repository<T> : IRepository<T> where T : class
{
	private readonly ITransactionManager _transactionManager;

	public ILogger Logger { get; set; }

	protected virtual ISession Session => _transactionManager.GetSession();

	public virtual IQueryable<T> Table => LinqExtensionMethods.Cacheable<T>(Session.Query<T>());

	IQueryable<T> IRepository<T>.Table => Table;

	public Repository(ITransactionManager transactionManager)
	{
		_transactionManager = transactionManager;
		Logger = NullLogger.Instance;
	}

	void IRepository<T>.Create(T entity)
	{
		Create(entity);
	}

	void IRepository<T>.Update(T entity)
	{
		Update(entity);
	}

	void IRepository<T>.Delete(T entity)
	{
		Delete(entity);
	}

	void IRepository<T>.Copy(T source, T target)
	{
		Copy(source, target);
	}

	void IRepository<T>.Flush()
	{
		Flush();
	}

	T IRepository<T>.Get(int id)
	{
		return Get(id);
	}

	T IRepository<T>.Get(Expression<Func<T, bool>> predicate)
	{
		return Get(predicate);
	}

	int IRepository<T>.Count(Expression<Func<T, bool>> predicate)
	{
		return Count(predicate);
	}

	IEnumerable<T> IRepository<T>.Fetch(Expression<Func<T, bool>> predicate)
	{
		return Fetch(predicate).ToReadOnlyCollection();
	}

	IEnumerable<T> IRepository<T>.Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order)
	{
		return Fetch(predicate, order).ToReadOnlyCollection();
	}

	IEnumerable<T> IRepository<T>.Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order, int skip, int count)
	{
		return Fetch(predicate, order, skip, count).ToReadOnlyCollection();
	}

	public virtual T Get(int id)
	{
		return Session.Get<T>((object)id);
	}

	public virtual T Get(Expression<Func<T, bool>> predicate)
	{
		return Fetch(predicate).SingleOrDefault();
	}

	public virtual void Create(T entity)
	{
		Logger.Debug("Create {0}", entity);
		Session.Save((object)entity);
	}

	public virtual void Update(T entity)
	{
		Logger.Debug("Update {0}", entity);
		Session.Evict((object)entity);
		Session.Merge<T>(entity);
	}

	public virtual void Delete(T entity)
	{
		Logger.Debug("Delete {0}", entity);
		Session.Delete((object)entity);
	}

	public virtual void Copy(T source, T target)
	{
		Logger.Debug("Copy {0} {1}", source, target);
		IClassMetadata classMetadata = Session.get_SessionFactory().GetClassMetadata(typeof(T));
		object[] propertyValues = classMetadata.GetPropertyValues((object)source);
		for (int j = 0; j < propertyValues.Length; j++)
		{
			object obj = propertyValues[j];
			if (obj != null)
			{
				Type type = obj.GetType();
				if ((from i in type.GetInterfaces()
					where i.IsGenericType
					select i).Any((Type i) => i.GetGenericTypeDefinition() == typeof(IList<>)))
				{
					Type type2 = type.GetGenericArguments().First();
					Type type3 = typeof(List<>).MakeGenericType(type2);
					IList list = (IList)obj;
					int num = j;
					object[] args = new IList[1] { list };
					propertyValues[num] = Activator.CreateInstance(type3, args);
				}
			}
		}
		classMetadata.SetPropertyValues((object)target, propertyValues);
	}

	public virtual void Flush()
	{
		Session.Flush();
	}

	public virtual int Count(Expression<Func<T, bool>> predicate)
	{
		return Fetch(predicate).Count();
	}

	public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate)
	{
		return Table.Where(predicate);
	}

	public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order)
	{
		Orderable<T> orderable = new Orderable<T>(Fetch(predicate));
		order(orderable);
		return orderable.Queryable;
	}

	public virtual IQueryable<T> Fetch(Expression<Func<T, bool>> predicate, Action<Orderable<T>> order, int skip, int count)
	{
		return Fetch(predicate, order).Skip(skip).Take(count);
	}
}
