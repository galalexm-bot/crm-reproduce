using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class ImportObject
{
	public IList<PropertyValue> Values { get; private set; }

	public Type ObjectType { get; private set; }

	public PropertyValue GetOrCreateProperty(MapPropertyInfo propertyInfo)
	{
		PropertyValue propertyValue = Values.FirstOrDefault((PropertyValue v) => v.PropertyInfo.Name == propertyInfo.Name);
		if (propertyValue == null)
		{
			propertyValue = new PropertyValue(propertyInfo);
			Values.Add(propertyValue);
		}
		return propertyValue;
	}

	public ImportObject(Type objectType)
	{
		ObjectType = objectType;
		Values = new List<PropertyValue>();
	}

	public override string ToString()
	{
		return ObjectType.Name;
	}

	public bool IsEqualsForKey(ImportObject importObject)
	{
		if (ObjectType != importObject.ObjectType)
		{
			return false;
		}
		List<PropertyValue> list = importObject.Values.Where((PropertyValue v) => v.PropertyInfo.ImportKey).ToList();
		List<PropertyValue> list2 = Values.Where((PropertyValue v) => v.PropertyInfo.ImportKey).ToList();
		if (list.Count != list2.Count)
		{
			return false;
		}
		foreach (PropertyValue value in list)
		{
			PropertyValue myValue = list2.FirstOrDefault((PropertyValue v) => v.PropertyInfo.Name == value.PropertyInfo.Name);
			if (myValue == null || value.Columns.Count != myValue.Columns.Count || value.Columns.All((KeyValuePair<string, object> column) => !myValue.Columns.ContainsKey(column.Key) || (myValue.Columns[column.Key] == null && value.Columns[column.Key] != null) || !myValue.Columns[column.Key].Equals(value.Columns[column.Key])))
			{
				return false;
			}
		}
		return true;
	}

	public void MergeProperties(ImportObject importObject)
	{
		if (!IsEqualsForKey(importObject))
		{
			return;
		}
		foreach (PropertyValue value in importObject.Values.Where((PropertyValue v) => !v.PropertyInfo.ImportKey))
		{
			PropertyValue propertyValue = Values.FirstOrDefault((PropertyValue v) => v.PropertyInfo.Name == value.PropertyInfo.Name);
			if (propertyValue != null)
			{
				Values.Remove(propertyValue);
			}
			Values.Add(value);
		}
	}
}
