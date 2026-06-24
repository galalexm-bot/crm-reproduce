using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Runtime.NH;

public interface IMainDatabaseProvider : IProvider, IConfigurableProvider, IDisposable
{
	string ConnectionString { get; }

	string DataProviderName { get; }

	bool Enabled { get; }

	ITransformationProvider CreateTransformationProvider();

	SqlString EqualToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery, string lhsPropertyPath, [NotNull] IEntityPropertyMetadata lhsPropertyMetadata, object rhsValue);

	SqlString EqualToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery, SqlString[] lhsColumnNames, IEntityPropertyMetadata lhsPropertyMetadata, SqlString[] rhsColumnNames, IEntityPropertyMetadata rhsPropertyMetadata);
}
