using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Model.Helpers;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Extensions;

public static class TypeDescriptorExtensions
{
	public static bool IsEmptyOrDefault(this ITypeDescriptor typeDescriptor, IMetadataServiceContext metadataServiceContext, IPropertyMetadata propertyMetadata, object val)
	{
		if (val == null)
		{
			return true;
		}
		if (propertyMetadata == null)
		{
			return true;
		}
		if (DefaultValueHelper.CanBeNullableProperty(typeDescriptor, propertyMetadata))
		{
			return false;
		}
		return DefaultValueHelper.GetCurrentDefaultValue(metadataServiceContext, propertyMetadata)?.Equals(val) ?? false;
	}
}
