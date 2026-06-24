using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Exceptions;
using EleWise.ELMA.Common.BulkDataImport.Helpers;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Common.BulkDataImport.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using NHibernate;

namespace EleWise.ELMA.Common.BulkDataImport.Services;

[Service]
internal class BulkDataImportDataBaseService : IBulkDataImportDataBaseService
{
	private const string OuterSystemIdFieldName = "@Id";

	private const string IdFieldName = "Id";

	private const string ParamDefaultName = "p_BDI";

	private const string AliasDefault = "this_";

	private const string LoggerName = "BulkDataImport";

	private readonly ITransformationProvider transformationProvider;

	private readonly ILockManager lockManager;

	private readonly ISessionProvider sessionProvider;

	public BulkDataImportDataBaseService(ITransformationProvider provider, ILockManager lockManager, ISessionProvider sessionProvider)
	{
		transformationProvider = provider;
		this.lockManager = lockManager;
		this.sessionProvider = sessionProvider;
	}

	public BulkDataImportDataBaseResult Execute(Guid workUid, MapDataSetList mapDataSetList)
	{
		try
		{
			BulkDataImportHelper.CheckStopCommand(workUid);
			List<Type> list = new List<Type>();
			foreach (MapDataSet mapDataSet in mapDataSetList)
			{
				BulkDataImportHelper.CheckStopCommand(workUid);
				list.Add(mapDataSet.MapInfo.ObjectType);
				for (int i = 0; i < mapDataSet.PageCount; i++)
				{
					BulkDataImportHelper.CheckStopCommand(workUid);
					AddIdFields(mapDataSet);
					IList<Dictionary<string, object>> list3;
					if (mapDataSet.MapInfo.Keys.Count <= 0)
					{
						IList<Dictionary<string, object>> list2 = new List<Dictionary<string, object>>();
						list3 = list2;
					}
					else
					{
						list3 = FindExistsRecords(mapDataSet);
					}
					IList<Dictionary<string, object>> existObjects = list3;
					UpdateIdField(mapDataSet, existObjects);
					mapDataSet.InsertedIds = SetInnerIds(mapDataSet);
					if (!SendInsert(mapDataSet))
					{
						CleanUpCaches(list);
						return new BulkDataImportDataBaseResult(success: false);
					}
					mapDataSet.SetNextPage();
				}
				mapDataSet.ResetPage();
			}
			foreach (MapDataSet mapDataSet2 in mapDataSetList)
			{
				BulkDataImportDataBaseResult result = SendUpdate(mapDataSet2);
				if (!result.Success)
				{
					CleanUpCaches(list);
					return result;
				}
			}
			foreach (MapDataSet mapDataSet3 in mapDataSetList)
			{
				if (mapDataSet3.Relations.Count > 0)
				{
					DropOldRelationTableData(mapDataSet3);
					InsertRelationRecords(mapDataSet3);
				}
			}
			CleanUpCaches(list);
			return new BulkDataImportDataBaseResult(success: true);
		}
		catch (StopImportException exception)
		{
			return new BulkDataImportDataBaseResult(exception);
		}
		catch (Exception exception2)
		{
			using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "Execute");
			bulkDataImportLogger.Error(exception2);
			return new BulkDataImportDataBaseResult(exception2);
		}
	}

	private void AddIdFields(MapDataSet info)
	{
		using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "AddIdFields");
		foreach (DataTable item in info.DataSource)
		{
			if (!item.Columns.Contains("Id"))
			{
				DataColumn dataColumn = new DataColumn("Id", typeof(long));
				item.Columns.Add(dataColumn);
				dataColumn.SetOrdinal(0);
			}
			if (!item.Columns.Contains("@Id"))
			{
				BulkDataImportException ex = new BulkDataImportException(SR.T("Одна из таблиц маппинга не содержит сквозного поля Id внешней системы. Импорт невозможен."));
				bulkDataImportLogger.Error(ex);
				throw ex;
			}
		}
	}

	private IList<Dictionary<string, object>> FindExistsRecords(MapDataSet dataSet)
	{
		string headerTableName = dataSet.HeaderTable.TableName;
		Dictionary<string, DataTable> source = OrderTables(dataSet.DataSource, headerTableName);
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		List<string> list3 = new List<string>();
		for (int i = dataSet.CurrentRowIndex; i < dataSet.MaxPageIndex; i++)
		{
			list3.Clear();
			foreach (MapPropertyInfo property in dataSet.MapInfo.Properties)
			{
				if (!property.ImportKey)
				{
					continue;
				}
				foreach (string key in property.Columns)
				{
					KeyValuePair<string, DataTable> keyValuePair = source.FirstOrDefault((KeyValuePair<string, DataTable> a) => a.Value != null && a.Value.Columns.Contains(key));
					string text = keyValuePair.Key + "." + transformationProvider.Dialect.QuoteIfNeeded(key);
					object value = keyValuePair.Value.Rows[i][key];
					string text2 = "p_BDI" + dictionary.Count;
					list3.Add($"{text}={transformationProvider.ParameterSeparator}{text2}");
					dictionary.Add(text2, value);
					if (i == dataSet.CurrentRowIndex)
					{
						if (property.PropertyMetadata.TypeUid == GuidDescriptor.UID)
						{
							text = $"{transformationProvider.Dialect.GuidToCharFromSqlWithoutQuote(text)} as {transformationProvider.Dialect.QuoteIfNeeded(key)}";
						}
						list.Add(text);
					}
				}
			}
			list2.Add("(" + string.Join(" and ", list3) + ")");
		}
		string text3 = string.Join(" ", from a in source
			where a.Value.TableName != headerTableName
			select a into b
			select string.Format("LEFT OUTER  JOIN {0} {1} on {1}.{2} = {3}.{2}", transformationProvider.Dialect.QuoteIfNeeded(b.Value.TableName), b.Key, transformationProvider.Dialect.QuoteIfNeeded("Id"), "this_"));
		string sql = string.Format("select {2}.{5}, {0} from {1} {2} {3} where {4}", string.Join(", ", list), transformationProvider.Dialect.QuoteIfNeeded(headerTableName), "this_", text3, string.Join(" or ", list2), transformationProvider.Dialect.QuoteIfNeeded("Id"));
		List<Dictionary<string, object>> list4 = new List<Dictionary<string, object>>();
		using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "FindExistsRecords");
		try
		{
			using IDataReader dataReader = transformationProvider.ExecuteQuery(sql, dictionary);
			while (dataReader.Read())
			{
				Dictionary<string, object> dictionary2 = new Dictionary<string, object> { 
				{
					"Id",
					dataReader["Id"]
				} };
				foreach (MapPropertyInfo property2 in dataSet.MapInfo.Properties)
				{
					if (!property2.ImportKey)
					{
						continue;
					}
					foreach (string column in property2.Columns)
					{
						if (dataReader[column] != null && dataReader[column] != DBNull.Value)
						{
							if (property2.PropertyMetadata.TypeUid == GuidDescriptor.UID)
							{
								dictionary2.Add(column, new Guid(dataReader[column].ToString()));
							}
							else
							{
								dictionary2.Add(column, dataReader[column]);
							}
						}
					}
				}
				list4.Add(dictionary2);
			}
			return list4;
		}
		catch (Exception exception)
		{
			bulkDataImportLogger.Error(exception);
			return list4;
		}
	}

	private void UpdateIdField(MapDataSet mapInfo, IList<Dictionary<string, object>> existObjects)
	{
		mapInfo.InsertedRowsCount = mapInfo.PageSize;
		foreach (Dictionary<string, object> existObject in existObjects)
		{
			for (int i = mapInfo.CurrentRowIndex; i < mapInfo.MaxPageIndex; i++)
			{
				bool flag = true;
				foreach (string existObjectKey in existObject.Keys)
				{
					if (!(existObjectKey == "Id") && !mapInfo.DataSource.FirstOrDefault((DataTable a) => a.Columns.Contains(existObjectKey)).Rows[i][existObjectKey].Equals(existObject[existObjectKey]))
					{
						flag = false;
					}
				}
				if (!flag)
				{
					continue;
				}
				mapInfo.InsertedRowsCount--;
				foreach (DataTable item in mapInfo.DataSource)
				{
					if (!(item.Rows[i]["@Id"] is ObjectId objectId))
					{
						item.Rows[i]["@Id"] = new ObjectId(null)
						{
							Id = existObject["Id"]
						};
					}
					else
					{
						objectId.Id = existObject["Id"];
					}
					item.Rows[i]["Id"] = existObject["Id"];
				}
			}
		}
	}

	private List<long> SetInnerIds(MapDataSet dataSet)
	{
		List<long> list = new List<long>();
		long[] array = transformationProvider.ReserveIds(dataSet.InsertedRowsCount, dataSet.HeaderTable.TableName);
		int num = 0;
		for (int i = dataSet.CurrentRowIndex; i < dataSet.MaxPageIndex; i++)
		{
			if (dataSet.HeaderTable.Rows[i]["Id"] != DBNull.Value)
			{
				continue;
			}
			foreach (DataTable item in dataSet.DataSource)
			{
				item.Rows[i]["Id"] = array[num];
				((ObjectId)item.Rows[i]["@Id"]).Id = array[num];
			}
			list.Add(array[num]);
			num++;
		}
		using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "SetInnerIds");
		if (num > dataSet.InsertedRowsCount)
		{
			bulkDataImportLogger.Error(new BulkDataImportException(SR.T("Произошла ошибка во время присваивания идентификаторов")));
			return list;
		}
		return list;
	}

	private bool SendInsert(MapDataSet mapInfo)
	{
		foreach (DataTable item in mapInfo.DataSource)
		{
			DataTable dataTable = item.Clone();
			for (int i = mapInfo.CurrentRowIndex; i < mapInfo.MaxPageIndex; i++)
			{
				DataRow dataRow = item.Rows[i];
				object outerObjId = ((ObjectId)dataRow["@Id"]).Id;
				object obj = dataRow["Id"];
				if (mapInfo.InsertedIds.Contains((long)obj) && !dataTable.Rows.CastToListOrNull<DataRow>().Any((DataRow a) => ((ObjectId)a["@Id"]).Id == outerObjId))
				{
					dataRow["Id"] = outerObjId;
					dataTable.ImportRow(dataRow);
				}
			}
			if (dataTable.Rows.Count == 0)
			{
				return true;
			}
			bool needUidColumn = item == mapInfo.HeaderTable && mapInfo.MapInfo.Metadata is EntityMetadata;
			ReplaceObjectIdColumn(dataTable, mapInfo.MapInfo, forInsert: true, needUidColumn);
			using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "SendInsert");
			try
			{
				transformationProvider.BulkInsert(dataTable.TableName, dataTable, shouldGenerateId: false);
			}
			catch (Exception ex)
			{
				bulkDataImportLogger.Error(ex);
				throw ex;
			}
		}
		return true;
	}

	private BulkDataImportDataBaseResult SendUpdate(MapDataSet mapInfo)
	{
		foreach (DataTable item in mapInfo.DataSource)
		{
			if (item.Columns["Id"] == null || item.Columns.Count == 1)
			{
				continue;
			}
			DataTable dataTable = item.Clone();
			for (int i = 0; i < item.Rows.Count; i++)
			{
				DataRow dataRow = item.Rows[i];
				object outerObjId = ((ObjectId)dataRow["@Id"]).Id;
				if (!dataTable.Rows.CastToListOrNull<DataRow>().Any((DataRow a) => ((ObjectId)a["@Id"]).Id == outerObjId))
				{
					dataTable.ImportRow(dataRow);
				}
			}
			if (dataTable.Rows.Count == 0)
			{
				return new BulkDataImportDataBaseResult(success: true);
			}
			using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "SendRequests");
			ReplaceObjectIdColumn(dataTable, mapInfo.MapInfo);
			try
			{
				transformationProvider.BulkUpdate(dataTable.TableName, dataTable, "Id");
			}
			catch (Exception exception)
			{
				bulkDataImportLogger.Error(exception);
				return new BulkDataImportDataBaseResult(exception);
			}
		}
		return new BulkDataImportDataBaseResult(success: true);
	}

	private void ReplaceObjectIdColumn(DataTable table, MapInfo mapInfo, bool forInsert = false, bool needUidColumn = false)
	{
		using (new BulkDataImportLogger("BulkDataImport", "ReplaceObjectIdColumn"))
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			foreach (DataColumn column in table.Columns)
			{
				if (!(column.ColumnName == "Id") && column.ColumnName.StartsWith("@"))
				{
					list.Add(column.ColumnName);
					list2.Add(column.ColumnName.Substring("@".Length));
				}
			}
			if (!forInsert)
			{
				for (int i = 0; i < list2.Count; i++)
				{
					if (!table.Columns.Contains(list2[i]))
					{
						table.Columns.Add(list2[i], typeof(long));
					}
				}
				foreach (DataRow row in table.Rows)
				{
					for (int j = 0; j < list.Count; j++)
					{
						if (row[list[j]] is ObjectId objectId)
						{
							if (objectId.Id != null)
							{
								row[list2[j]] = objectId.Id;
							}
						}
						else
						{
							row[list2[j]] = row[list[j]];
						}
					}
				}
			}
			else if (needUidColumn)
			{
				if (!table.Columns.Contains("Uid"))
				{
					table.Columns.Add("Uid", typeof(Guid));
				}
				foreach (DataRow row2 in table.Rows)
				{
					object obj = row2["Uid"];
					if (obj == null || obj == DBNull.Value || obj.Equals(Guid.Empty))
					{
						row2["Uid"] = Guid.NewGuid();
					}
				}
			}
			foreach (string item in list)
			{
				table.Columns.Remove(item);
			}
		}
	}

	private void DropOldRelationTableData(MapDataSet dataSet)
	{
		List<long> list = new List<long>();
		foreach (DataRow row in dataSet.HeaderTable.Rows)
		{
			list.Add((long)row["Id"]);
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (MapPropertyInfo property in dataSet.MapInfo.Properties)
		{
			if (!property.IsRelations || !(property.PropertyMetadata.Settings is EntitySettings entitySettings) || string.IsNullOrWhiteSpace(entitySettings.ParentColumnName))
			{
				continue;
			}
			int num;
			for (int i = 0; i < list.Count; i += num)
			{
				dictionary.Clear();
				num = 0;
				for (num = 0; num < 1500; num++)
				{
					int num2 = i + num;
					if (num2 >= list.Count)
					{
						break;
					}
					dictionary.Add($"deleteIds{num}", list[num2]);
				}
				string sql = string.Format("delete from {0} where {1} in ({2})", property.TableName, entitySettings.ParentColumnName, string.Join(",", dictionary.Select((KeyValuePair<string, object> a) => $"{transformationProvider.ParameterSeparator}{a.Key}")));
				transformationProvider.ExecuteNonQuery(sql, dictionary);
			}
		}
	}

	private void InsertRelationRecords(MapDataSet dataSet)
	{
		List<Tuple<ObjectId, ObjectId>> list = new List<Tuple<ObjectId, ObjectId>>();
		foreach (MapPropertyInfo relationProperty in dataSet.MapInfo.Properties)
		{
			if (!relationProperty.IsRelations)
			{
				continue;
			}
			DataTable dataTable = dataSet.Relations.FirstOrDefault((DataTable a) => a.TableName == relationProperty.TableName);
			if (dataTable == null || dataTable.Columns.Count != 2)
			{
				continue;
			}
			string columnName = dataTable.Columns[0].ColumnName.Substring("@".Length);
			string columnName2 = dataTable.Columns[1].ColumnName.Substring("@".Length);
			DataTable dataTable2 = new DataTable(dataTable.TableName);
			AddRealColumn(dataTable2, columnName, typeof(long));
			AddRealColumn(dataTable2, columnName2, typeof(long));
			list.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				DataRow dataRow2 = dataTable2.NewRow();
				ObjectId parentColumn = row[relationProperty.Columns.First()] as ObjectId;
				ObjectId childColumn = row[relationProperty.Columns.Last()] as ObjectId;
				if (parentColumn != null && childColumn != null && !list.Any((Tuple<ObjectId, ObjectId> a) => a.Item1.Id == parentColumn.Id && a.Item2.Id == childColumn.Id))
				{
					dataRow2[columnName] = parentColumn.Id;
					dataRow2[columnName2] = childColumn.Id;
					list.Add(new Tuple<ObjectId, ObjectId>(parentColumn, childColumn));
					dataTable2.Rows.Add(dataRow2);
				}
			}
			using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "SendUpdate");
			try
			{
				transformationProvider.BulkInsert(dataTable2.TableName, dataTable2, shouldGenerateId: false);
			}
			catch (Exception exception)
			{
				bulkDataImportLogger.Error(exception);
			}
		}
	}

	private void AddRealColumn(DataTable table, string columnName, Type columnType)
	{
		if (!table.Columns.Contains(columnName))
		{
			table.Columns.Add(columnName, columnType);
		}
	}

	private Dictionary<string, DataTable> OrderTables(IList<DataTable> dataSource, string tableName)
	{
		Dictionary<string, DataTable> dictionary = new Dictionary<string, DataTable>();
		DataTable dataTable = dataSource.FirstOrDefault((DataTable a) => a.TableName == tableName);
		if (dataTable == null)
		{
			return null;
		}
		dictionary.Add("this_", dataTable);
		List<DataTable> list = dataSource.Where((DataTable a) => a.TableName != tableName).ToList();
		for (int i = 0; i < list.Count; i++)
		{
			dictionary.Add("this_" + i, list[i]);
		}
		return dictionary;
	}

	private void CleanUpCaches(List<Type> types)
	{
		sessionProvider.GetSession("").CleanUpCache(types.ToArray());
	}
}
