using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface ICopyableTypeDescriptor
{
	void Copy(object obj, object target, ClassMetadata metadata, PropertyMetadata propertyMetadata);
}
