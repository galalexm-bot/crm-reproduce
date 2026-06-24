using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Types.Models;

namespace EleWise.ELMA.Model.Types;

public interface ITypeGenerationInfo
{
	bool IsNullable(IPropertyMetadata property);

	bool HasSetter(IPropertyMetadata property);

	bool ShouldSerialize(IPropertyMetadata property, IMetadata metadata);

	Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo);

	Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo);
}
