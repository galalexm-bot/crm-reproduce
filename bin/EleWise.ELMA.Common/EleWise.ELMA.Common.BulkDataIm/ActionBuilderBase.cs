using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping;

public abstract class ActionBuilderBase
{
	protected string columnName;

	protected bool IsKeyField;

	protected bool IgnoreMap;

	protected Dictionary<string, List<string>> PropertyRelations = new Dictionary<string, List<string>>();

	internal string PropertyName { get; private set; }

	internal string ColumnName => columnName;

	internal ActionBuilderBase(string propertyName)
	{
		PropertyName = propertyName;
	}

	internal bool IsKey()
	{
		return IsKeyField;
	}

	internal bool IsIgnore()
	{
		return IgnoreMap;
	}

	internal abstract bool ActionExist();

	internal abstract object Action(MapObject mapObject, DataRow row, SmartLogger logger, int? index, int count);
}
