using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface IPropertyTypeInfo
{
	string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata);

	string GetTypeDisplayName(Guid subTypeUid);
}
