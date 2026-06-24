using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Import.Web.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Import.Web.Extensions;

public abstract class EntityImportEventHandler : IEntityImportEventHandler
{
	public abstract Type Type { get; }

	public object CreateImportSessionData(Dictionary<IEntityImportEventHandler, object> current)
	{
		return null;
	}

	public void AfterParse(IEntity<long> entity, object importSessionData)
	{
		AfterParse(entity);
	}

	public void CheckRequiredProperties(IEntity<long> entity, object importSessionData)
	{
		CheckRequiredProperties(entity);
	}

	public void OnCreate(IEntity<long> entity, object importSessionData)
	{
		OnCreate(entity);
	}

	public ReflectedEntityPropertyInfo GetEntityPropertyByHeader(string masterPropName, string slavePropName, Type type, object importSessionData)
	{
		return GetEntityPropertyByHeader(masterPropName, slavePropName, type);
	}

	public bool SetEntityPropertyValue(IEntity<long> entity, ReflectedEntityPropertyInfo entityProperty, string value, bool allowAddToDict, bool saveEntity, List<LogMessage> logMessages, string infoTemplate, object importSessionData)
	{
		return SetEntityPropertyValue(entity, entityProperty, value, allowAddToDict, saveEntity, logMessages, infoTemplate);
	}

	public virtual void AfterParse(IEntity<long> entity)
	{
	}

	public virtual void CheckRequiredProperties(IEntity<long> entity)
	{
	}

	public virtual void OnCreate(IEntity<long> entity)
	{
	}

	public virtual ReflectedEntityPropertyInfo GetEntityPropertyByHeader(string masterPropName, string slavePropName, Type type)
	{
		return null;
	}

	public virtual bool SetEntityPropertyValue(IEntity<long> entity, ReflectedEntityPropertyInfo entityProperty, string value, bool allowAddToDict, bool saveEntity, List<LogMessage> logMessages, string infoTemplate)
	{
		return false;
	}
}
public abstract class EntityImportEventHandler<T> : IEntityImportEventHandler where T : new()
{
	public abstract Type Type { get; }

	public virtual object CreateImportSessionData(Dictionary<IEntityImportEventHandler, object> current)
	{
		return new T();
	}

	public void AfterParse(IEntity<long> entity, object importSessionData)
	{
		AfterParse(entity, (T)importSessionData);
	}

	public void CheckRequiredProperties(IEntity<long> entity, object importSessionData)
	{
		CheckRequiredProperties(entity, (T)importSessionData);
	}

	public void OnCreate(IEntity<long> entity, object importSessionData)
	{
		OnCreate(entity, (T)importSessionData);
	}

	public ReflectedEntityPropertyInfo GetEntityPropertyByHeader(string masterPropName, string slavePropName, Type type, object importSessionData)
	{
		return GetEntityPropertyByHeader(masterPropName, slavePropName, type, (T)importSessionData);
	}

	public bool SetEntityPropertyValue(IEntity<long> entity, ReflectedEntityPropertyInfo entityProperty, string value, bool allowAddToDict, bool saveEntity, List<LogMessage> logMessages, string infoTemplate, object importSessionData)
	{
		return SetEntityPropertyValue(entity, entityProperty, value, allowAddToDict, saveEntity, logMessages, infoTemplate, (T)importSessionData);
	}

	public virtual void AfterParse(IEntity<long> entity, T importSessionData)
	{
	}

	public virtual void CheckRequiredProperties(IEntity<long> entity, T importSessionData)
	{
	}

	public virtual void OnCreate(IEntity<long> entity, T importSessionData)
	{
	}

	public virtual ReflectedEntityPropertyInfo GetEntityPropertyByHeader(string masterPropName, string slavePropName, Type type, T importSessionData)
	{
		return null;
	}

	public virtual bool SetEntityPropertyValue(IEntity<long> entity, ReflectedEntityPropertyInfo entityProperty, string value, bool allowAddToDict, bool saveEntity, List<LogMessage> logMessages, string infoTemplate, T importSessionData)
	{
		return false;
	}
}
