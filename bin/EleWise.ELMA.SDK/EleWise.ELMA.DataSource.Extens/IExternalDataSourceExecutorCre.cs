using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.DataSource.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IExternalDataSourceExecutorCreator
{
	string Name { get; }

	Guid TypeUid { get; }

	IExternalDataSourceExecutor Create(string connectionString);
}
