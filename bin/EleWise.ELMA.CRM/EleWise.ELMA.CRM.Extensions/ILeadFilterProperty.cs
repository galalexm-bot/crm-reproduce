using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using NHibernate;

namespace EleWise.ELMA.CRM.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ILeadFilterProperty
{
	bool Check(EntityPropertyMetadata property);

	ICollection<long> GetFilterPropertyList(ICriteria criteria, Type type, EntityPropertyMetadata property, object propertyValue, string nameReturnProperty);
}
