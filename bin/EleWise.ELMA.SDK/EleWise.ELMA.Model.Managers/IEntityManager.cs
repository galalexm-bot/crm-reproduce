using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Model.Managers;

[ExtensionPoint(false, ComponentType.Server, ServiceScope.Application)]
public interface IEntityManager
{
	object Create();

	bool IsNew(object obj);

	bool IsDirty(object obj);

	bool IsDirty(object obj, object originalState);

	Guid[] GetDirtyPropertyUids(object obj);

	Guid[] GetDirtyPropertyUids(object obj, object originalState);

	object GetCurrentState(object obj);

	object Load(object id);

	object LoadOrNull(object id);

	object LoadOrCreate(object id);

	object LoadOrCreate(Guid uid);

	object Load(Guid uid);

	object LoadOrNull(Guid uid);

	ActionCheckResult CanSave(object obj);

	void Save(object obj);

	ActionCheckResult CanDelete(object obj);

	void Delete(object obj);

	void Delete(string query);

	[Obsolete("При необходимости используйте собственную реализацию метода, текущая работает долго и может превысить допустимое время выполнения при большом количестве записей.")]
	void DeleteAll();

	void Refresh(object obj);

	void Refresh(object obj, LockMode mode);

	IEnumerable FindAll();

	IEnumerable FindByIdArray(object[] idArray);

	IEnumerable Find(FetchOptions fetchOptions);

	IEnumerable Find(IEntityFilter filter, FetchOptions fetchOptions);

	IEnumerable<T> Find<T>(IEntityFilter filter, FetchOptions fetchOptions);

	long Count();

	long Count(IEntityFilter filter);

	void CheckFilter(IEntityFilter filter);

	ICollection<PT> Projection<PT>(string propertyName);

	void SetupFilter(ICriteria criteria, IEntityFilter filter);

	DetachedCriteria CreateDetachedCriteria(FetchOptions fetchOptions, Type type, string alias = null, IEntityFilter filter = null);

	void FilterDetachedCriteria(DetachedCriteria detachedCriteria, FetchOptions fetchOptions, Type type, IEntityFilter filter = null);

	SecurityException CreateSecurityException(string text, object id);

	ExportRuleList ExportRules();

	bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null);
}
[ExtensionPoint(false, ComponentType.Server, ServiceScope.Application)]
public interface IEntityManager<T> : IEntityManager where T : IEntity
{
	[NotNull]
	new T Create();

	[NotNull]
	new T Load(object id);

	[CanBeNull]
	new T LoadOrNull(object id);

	[NotNull]
	new T LoadOrCreate(object id);

	[NotNull]
	new T LoadOrCreate(Guid uid);

	[NotNull]
	new T Load(Guid uid);

	[CanBeNull]
	new T LoadOrNull(Guid uid);

	ActionCheckResult CanSave(T obj);

	void Save(T obj);

	ActionCheckResult CanDelete(T obj);

	void Delete(T obj);

	void Refresh(T obj);

	void Refresh(T obj, LockMode mode);

	bool IsNew(T obj);

	bool IsDirty(T obj);

	bool IsDirty(T obj, object originalState);

	Guid[] GetDirtyPropertyUids(T obj);

	Guid[] GetDirtyPropertyUids(T obj, object originalState);

	object GetCurrentState(T obj);

	new ICollection<T> FindAll();

	new ICollection<T> FindByIdArray(object[] idArray);

	new ICollection<T> Find(FetchOptions fetchOptions);

	new ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions);

	ICollection<T> Find(Expression<Func<T, bool>> condition);

	ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition);

	ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions);

	ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition, FetchOptions fetchOptions);

	ICollection<T> Find(string eqlFilter);
}
public interface IEntityManager<T, in IdT> : IEntityManager<T>, IEntityManager where T : IEntity<IdT>
{
	[NotNull]
	T Load(IdT id);

	[CanBeNull]
	T LoadOrNull(IdT id);

	[NotNull]
	T LoadOrCreate(IdT id);

	ICollection<T> FindByIdArray(IdT[] idArray);
}
