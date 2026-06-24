using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.Db;

namespace EleWise.ELMA.History.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
internal interface ITransformationProviderExtension
{
	QueryTableType HistoryObject { get; }

	QueryTableType HistoryObjectObserver { get; }

	QueryTableType HistoryUpdateQueueItem { get; }

	bool CanUse { get; }

	string SysObjectName(string name);

	void InsertIfNotExists(string table, IDictionary<string, object> insertValues, bool isNeedInsertId, IEnumerable<string> columnsToCheck, IDictionary<string, object> paramValues = null);
}
