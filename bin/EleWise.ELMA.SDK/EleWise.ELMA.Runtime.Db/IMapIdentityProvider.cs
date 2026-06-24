using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Runtime.Db;

public interface IMapIdentityProvider
{
	void SetGenerator(IIdMapper mapping, string tableName, string idColumnName);
}
