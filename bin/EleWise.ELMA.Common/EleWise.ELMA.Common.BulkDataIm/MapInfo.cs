using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class MapInfo
{
	private IMetadataRuntimeService metadataRuntimeService;

	public Type ObjectType { get; private set; }

	public IMetadata Metadata { get; private set; }

	public IList<MapPropertyInfo> Properties { get; private set; }

	public IList<string> Keys => Properties.Where((MapPropertyInfo a) => a.ImportKey).SelectMany((MapPropertyInfo b) => b.Columns).ToList();

	public IList<ImportObject> Objects { get; private set; }

	public MapInfo(Type objectType, IMetadataRuntimeService MetadataRuntimeService)
	{
		Properties = new List<MapPropertyInfo>();
		Objects = new List<ImportObject>();
		ObjectType = objectType;
		Metadata = MetadataLoader.LoadMetadata(objectType);
		metadataRuntimeService = MetadataRuntimeService;
	}

	public MapPropertyInfo FindProperty(string name)
	{
		return Properties.FirstOrDefault((MapPropertyInfo p) => p.Name == name);
	}

	public bool IsEquals(MapInfo info)
	{
		return IsEquals(info.ObjectType, info.Properties.Select((MapPropertyInfo p) => p.Name).ToList(), (from p in info.Properties
			where p.ImportKey
			select p.Name).ToList());
	}

	public bool IsEquals(Type objectType, List<string> properties, List<string> keys)
	{
		if (ObjectType == objectType && Properties.Any((MapPropertyInfo p) => properties.Any((string property) => p.Name == property)))
		{
			if (keys.Count == 0 && !Properties.Any((MapPropertyInfo p) => p.ImportKey))
			{
				return true;
			}
			if (Properties.Any((MapPropertyInfo p) => keys.Any((string property) => p.ImportKey && p.Name == property)))
			{
				return true;
			}
		}
		return false;
	}

	public override string ToString()
	{
		return ObjectType.Name;
	}

	public MapDataSet ToDataSet()
	{
		MapDataSet mapDataSet = new MapDataSet(this);
		List<MapPropertyInfo> source = Properties.Where((MapPropertyInfo p) => !p.IsRelations).ToList();
		List<MapPropertyInfo> list = Properties.Where((MapPropertyInfo p) => p.IsRelations).ToList();
		EntityMetadata entityMetadata = Metadata as EntityMetadata;
		List<string> list2 = new List<string>();
		while (entityMetadata != null)
		{
			list2.Add(entityMetadata.TableName);
			Guid baseClassUid = entityMetadata.BaseClassUid;
			entityMetadata = ((baseClassUid != Guid.Empty) ? (MetadataLoader.LoadMetadata(baseClassUid) as EntityMetadata) : null);
		}
		foreach (MapPropertyInfo item in source.Where((MapPropertyInfo p) => !string.IsNullOrEmpty(p.TableName)))
		{
			CreatePropertyColumns(item, mapDataSet, list2);
		}
		foreach (MapPropertyInfo item2 in source.Where((MapPropertyInfo p) => string.IsNullOrEmpty(p.TableName)))
		{
			CreatePropertyColumns(item2, mapDataSet, list2);
		}
		foreach (ImportObject @object in Objects)
		{
			AddPropertyValue(@object.Values, mapDataSet);
		}
		foreach (MapPropertyInfo relation in list)
		{
			CreateRelationColumns(relation, mapDataSet);
			foreach (ImportObject object2 in Objects)
			{
				PropertyValue value = object2.Values.FirstOrDefault((PropertyValue v) => v.PropertyInfo == relation);
				AddRelationValues(value, mapDataSet);
			}
		}
		return mapDataSet;
	}

	private void CreatePropertyColumns(MapPropertyInfo mapPropertyInfo, MapDataSet mapResult, List<string> tables)
	{
		bool allTables = string.IsNullOrEmpty(mapPropertyInfo.TableName);
		if (allTables && tables.Count != 0)
		{
			foreach (string item3 in tables.Where((string t) => mapResult.DataSource.All((DataTable ds) => ds.TableName != t)).ToList())
			{
				DataTable item = new DataTable
				{
					TableName = item3
				};
				mapResult.DataSource.Add(item);
			}
		}
		List<DataTable> list = mapResult.DataSource.Where((DataTable t) => allTables || t.TableName == mapPropertyInfo.TableName).ToList();
		if (list.Count == 0)
		{
			DataTable item2 = new DataTable
			{
				TableName = mapPropertyInfo.TableName
			};
			mapResult.DataSource.Add(item2);
			list.Add(item2);
		}
		foreach (DataTable item4 in list)
		{
			foreach (string column in mapPropertyInfo.Columns)
			{
				int num = item4.Columns.IndexOf(column);
				if (num == -1)
				{
					if (mapPropertyInfo.PropertyExtension != null)
					{
						Type propertyDbType = mapPropertyInfo.PropertyExtension.GetPropertyDbType(mapPropertyInfo.PropertyMetadata);
						if (propertyDbType != null)
						{
							item4.Columns.Add(column, propertyDbType);
							continue;
						}
					}
					if (mapPropertyInfo.PropertyMetadata != null && metadataRuntimeService.GetTypeDescriptor(mapPropertyInfo.PropertyMetadata.TypeUid, mapPropertyInfo.PropertyMetadata.SubTypeUid) is IRuntimeTypeDescriptor runtimeTypeDescriptor)
					{
						item4.Columns.Add(column, runtimeTypeDescriptor.RuntimeType);
					}
					else
					{
						item4.Columns.Add(column, typeof(object));
					}
				}
				else
				{
					_ = item4.Columns[num];
				}
			}
		}
	}

	private void AddPropertyValue(IList<PropertyValue> values, MapDataSet mapResult)
	{
		Dictionary<string, DataRow> dictionary = mapResult.DataSource.ToDictionary((DataTable t) => t.TableName, delegate(DataTable t)
		{
			DataRow dataRow = t.NewRow();
			t.Rows.Add(dataRow);
			return dataRow;
		});
		foreach (PropertyValue propertyValue in values)
		{
			bool allTables = string.IsNullOrEmpty(propertyValue.PropertyInfo.TableName);
			foreach (DataTable item in mapResult.DataSource.Where((DataTable t) => allTables || t.TableName == propertyValue.PropertyInfo.TableName).ToList())
			{
				foreach (string key in propertyValue.Columns.Keys)
				{
					dictionary[item.TableName][key] = propertyValue.Columns[key] ?? DBNull.Value;
				}
			}
		}
	}

	private void CreateRelationColumns(MapPropertyInfo mapPropertyInfo, MapDataSet mapResult)
	{
		DataTable dataTable = mapResult.Relations.FirstOrDefault((DataTable t) => t.TableName == mapPropertyInfo.TableName);
		if (dataTable == null)
		{
			dataTable = new DataTable
			{
				TableName = mapPropertyInfo.TableName
			};
			mapResult.Relations.Add(dataTable);
		}
		foreach (string column in mapPropertyInfo.Columns)
		{
			int num = dataTable.Columns.IndexOf(column);
			if (num == -1)
			{
				dataTable.Columns.Add(column, typeof(object));
			}
			else
			{
				_ = dataTable.Columns[num];
			}
		}
	}

	private void AddRelationValues(PropertyValue value, MapDataSet mapResult)
	{
		if (value.Columns.Count != 2)
		{
			return;
		}
		DataTable dataTable = mapResult.Relations.FirstOrDefault((DataTable t) => t.TableName == value.PropertyInfo.TableName);
		if (dataTable == null)
		{
			return;
		}
		string text = value.Columns.Keys.First();
		string text2 = value.Columns.Keys.Last();
		if (!(value.Columns[text] is ObjectId value2))
		{
			return;
		}
		List<ObjectId> list = ((List<MapObject>)value.Columns[text2]).Cast<ObjectId>().ToList();
		if (list.Count == 0)
		{
			return;
		}
		foreach (ObjectId item in list)
		{
			DataRow dataRow = dataTable.NewRow();
			dataTable.Rows.Add(dataRow);
			dataRow[text] = value2;
			dataRow[text2] = item;
		}
	}
}
