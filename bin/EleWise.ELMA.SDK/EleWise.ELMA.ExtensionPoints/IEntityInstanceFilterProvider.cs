using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

public interface IEntityInstanceFilterProvider
{
	string GetFilterProviderData(IEntity entity, Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes);
}
