using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Import.Web.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Import.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityImportEventHandler
{
	Type Type { get; }

	object CreateImportSessionData(Dictionary<IEntityImportEventHandler, object> current);

	void AfterParse(IEntity<long> entity, object importSessionData);

	void CheckRequiredProperties(IEntity<long> entity, object importSessionData);

	void OnCreate(IEntity<long> entity, object importSessionData);

	ReflectedEntityPropertyInfo GetEntityPropertyByHeader(string masterPropName, string slavePropName, Type type, object importSessionData);

	bool SetEntityPropertyValue(IEntity<long> entity, ReflectedEntityPropertyInfo entityProperty, string value, bool allowAddToDict, bool saveEntity, List<LogMessage> logMessages, string infoTemplate, object importSessionData);
}
