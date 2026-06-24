using System;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Helpers;

public interface INHibernatePropertiesMapper
{
	void Property(string name, string columnName = null, Action<INHibernatePropertyTypeMapper> propertyTypeBuilder = null, bool notNull = true, string formula = null, string sqlType = null);

	void ManyToOne(string name, string columnName = null, CascadeMode cascadeMode = CascadeMode.None);

	void OneToManyCollection(string name, string tableName, string keyColumn, CascadeMode cascadeMode, int batchSize, Type comparerType);

	void ManyToManyCollection(string name, string tableName, string parentKeyColumn, string childKeyColumn, CascadeMode cascadeMode, int batchSize, Type comparerType, bool inverse = false);

	void Set(string name, string tableName, string parentKeyColumn, string childKeyColumn, CascadeMode cascadeMode, int batchSize, Type comparerType, Action<INHibernatePropertyTypeMapper> propertyTypeBuilder = null);
}
