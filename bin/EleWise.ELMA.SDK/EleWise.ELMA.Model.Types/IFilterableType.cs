using EleWise.ELMA.Model.Metadata;
using NHibernate;

namespace EleWise.ELMA.Model.Types;

public interface IFilterableType
{
	void ApplyFilterValue(ICriteria criteria, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, object value, string alias);
}
