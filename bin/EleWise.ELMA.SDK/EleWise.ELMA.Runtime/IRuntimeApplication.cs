using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Runtime.Cache;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.Runtime;

[ExtensionPoint(ComponentType.Server)]
public interface IRuntimeApplication
{
	RuntimeConfiguration Configuration { get; }

	Guid ConfigurationUid { get; }

	ConfigurationInfo ConfigurationInfo { get; }

	IMainDatabaseProvider MainProvider { get; }

	IEnumerable<IProvider> Providers { get; }

	DbPreUpdater DbPreUpdater { get; }

	ITransformationProvider TransformationProvider { get; }

	ApplicationStartCache ApplicationStartCache { get; }

	Guid ConnectionUid { get; }

	Guid InstanceUid { get; }

	bool IsStarted { get; }

	bool IsFirstServerInCluster { get; }

	bool IsConnectionAlive(Guid connectionUid);

	IEnumerable<Guid> GetActiveConnectionUids();

	void OnApplicationStarting();

	void OnApplicationStarted();

	int? GetCommandTimeout();

	int? SetCurrentContextTimeout(int? timeout);
}
