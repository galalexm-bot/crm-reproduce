using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping;

public class RulesBuilderBase
{
	internal List<RulesBuilderBase> RulesExtensions = new List<RulesBuilderBase>();

	internal Dictionary<string, ActionBuilderBase> ActionBuilders = new Dictionary<string, ActionBuilderBase>();

	internal Dictionary<string, MapBuilderBase> ImportBuilders = new Dictionary<string, MapBuilderBase>();

	internal Dictionary<string, Func<PropertyCollectionSettings, int>> PropertySettingsDictionary = new Dictionary<string, Func<PropertyCollectionSettings, int>>();

	internal Dictionary<string, Relation> RelationProperties = new Dictionary<string, Relation>();

	protected DataTable Table;

	internal RulesBuilderBase(DataTable table)
	{
		Table = table;
	}

	internal bool IsCollecttion(string propertyName)
	{
		return PropertySettingsDictionary.ContainsKey(propertyName);
	}

	internal bool CanMap(string propertyName, bool extension = true)
	{
		if (!ImportBuilders.ContainsKey(propertyName) && !ActionBuilders.ContainsKey(propertyName))
		{
			if (extension)
			{
				return RulesExtensions.Any((RulesBuilderBase r) => r.CanMap(propertyName));
			}
			return false;
		}
		return true;
	}

	internal bool IsKey(string propertyName, bool extension = true)
	{
		if (!ActionBuilders.ContainsKey(propertyName) || !ActionBuilders[propertyName].IsKey())
		{
			if (extension)
			{
				return RulesExtensions.Any((RulesBuilderBase r) => r.IsKey(propertyName));
			}
			return false;
		}
		return true;
	}

	internal bool IsIgnore(string propertyName, bool extension = true)
	{
		if (!ActionBuilders.ContainsKey(propertyName) || !ActionBuilders[propertyName].IsIgnore())
		{
			if (extension)
			{
				return RulesExtensions.Any((RulesBuilderBase r) => r.IsIgnore(propertyName));
			}
			return false;
		}
		return true;
	}
}
