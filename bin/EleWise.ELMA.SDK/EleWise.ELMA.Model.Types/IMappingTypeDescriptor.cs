using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface IMappingTypeDescriptor
{
	void CreatePropertyMapping(INHibernatePropertiesMapper mappingBuilder, ClassMetadata metadata, EntityPropertyMetadata propertyMetadata);
}
