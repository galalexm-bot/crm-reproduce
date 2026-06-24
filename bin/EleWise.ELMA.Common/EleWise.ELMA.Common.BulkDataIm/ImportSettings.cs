using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class ImportSettings
{
	private Dictionary<int, List<Pair<MapObject, Dictionary<string, object>>>> allObjects;

	public int? Index { get; private set; }

	public int Count { get; private set; }

	public IList<MapInfo> MapInfos { get; private set; }

	internal SmartLogger Logger { get; private set; }

	public bool ExceptionEnabled { get; private set; }

	public bool LoggerDisabled { get; private set; }

	internal ImportSettings(SmartLogger logger, bool exceptionEnabled, bool loggerDisabled, IList<MapInfo> mapInfo, int? index, int count)
		: this(logger, exceptionEnabled, loggerDisabled, mapInfo)
	{
		Index = index;
		Count = count;
	}

	internal ImportSettings(SmartLogger logger, bool exceptionEnabled, bool loggerDisabled, IList<MapInfo> mapInfo)
	{
		Logger = logger;
		ExceptionEnabled = exceptionEnabled;
		LoggerDisabled = loggerDisabled;
		MapInfos = mapInfo;
		allObjects = new Dictionary<int, List<Pair<MapObject, Dictionary<string, object>>>>();
	}

	public MapObject FindObject(Type objectType, Dictionary<string, object> keyValues)
	{
		if (allObjects.Count == 0)
		{
			return null;
		}
		int hashForKeys = GetHashForKeys(objectType, keyValues.Keys.ToList());
		allObjects.TryGetValue(hashForKeys, out var value);
		if (value == null)
		{
			return null;
		}
		foreach (Pair<MapObject, Dictionary<string, object>> item in value)
		{
			bool flag = true;
			foreach (string key in keyValues.Keys)
			{
				if (keyValues[key] == null || !keyValues[key].Equals(item.Second[key]))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return item.First;
			}
		}
		return null;
	}

	public void AddNewObject(MapObject @object, Dictionary<string, object> keyValues)
	{
		if (@object != null && FindObject(@object.ObjectType, keyValues) == null)
		{
			int hashForKeys = GetHashForKeys(@object.ObjectType, keyValues.Keys.ToList());
			Pair<MapObject, Dictionary<string, object>> item = new Pair<MapObject, Dictionary<string, object>>(@object, keyValues);
			if (allObjects.TryGetValue(hashForKeys, out var value))
			{
				value.Add(item);
				return;
			}
			allObjects.Add(hashForKeys, new List<Pair<MapObject, Dictionary<string, object>>> { item });
		}
	}

	internal ImportSettings CreateNew(SmartLogger logger)
	{
		return new ImportSettings(logger, ExceptionEnabled, LoggerDisabled, MapInfos, Index, Count)
		{
			allObjects = allObjects
		};
	}

	internal ImportSettings CreateNew(SmartLogger logger, int? index, int count)
	{
		return new ImportSettings(logger, ExceptionEnabled, LoggerDisabled, MapInfos, index, count)
		{
			allObjects = allObjects
		};
	}

	private int GetHashForKeys(Type objectType, List<string> keys)
	{
		HashCodeCombiner hashCodeCombiner = new HashCodeCombiner(objectType.GetHashCode());
		foreach (string key in keys)
		{
			hashCodeCombiner.AddObject(key);
		}
		return hashCodeCombiner.CombinedHash32;
	}
}
