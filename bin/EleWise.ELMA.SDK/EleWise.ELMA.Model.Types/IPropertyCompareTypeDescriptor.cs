using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface IPropertyCompareTypeDescriptor
{
	PropertyCompareData GetCompareData(object oldObject, object newObject, ClassMetadata metadata, PropertyMetadata propertyMetadata);

	void SetCompareData(object oldObject, object newObject, ClassMetadata metadata, PropertyMetadata propertyMetadata, PropertyCompareData compareData);
}
