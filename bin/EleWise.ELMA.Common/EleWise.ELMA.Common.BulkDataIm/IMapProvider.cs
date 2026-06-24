using System;
using System.Data;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IMapProvider
{
	bool Can(Type objectType);

	object Map(Type objectType, MapBuilderBase builder, DataRow row, Action<RulesBuilderBase> rulesAction, ImportSettings settings, Relation relation, Action<ActionInfo> action);
}
