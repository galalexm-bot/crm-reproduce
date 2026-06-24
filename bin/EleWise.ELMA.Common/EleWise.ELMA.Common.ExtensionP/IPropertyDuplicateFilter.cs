using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using NHibernate;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPropertyDuplicateFilter
{
	bool Check(EntityPropertyMetadata property);

	ICollection<long> GetDuplicatesForProperty(ICriteria criteria, Type type, EntityPropertyMetadata property, object propertyValue, string nameReturnProperty);
}
