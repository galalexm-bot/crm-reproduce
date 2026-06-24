using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping;

public abstract class MapBuilderBase
{
	protected string LoggerName = BulkDataImportLogger.LoggerPartName;

	internal SmartLogger BuilderLogger;

	public DataTable Table { get; protected set; }

	public bool AutoMapProperties { get; protected set; }

	public bool ExceptionEnabled { get; protected set; }

	public MapBuilderBase(DataTable table)
		: this()
	{
		SetDataSource(table);
	}

	public MapBuilderBase(DataTable table, string loggerName)
		: this(table)
	{
		if (string.IsNullOrEmpty(loggerName))
		{
			loggerName = BulkDataImportLogger.LoggerPartName;
		}
		LoggerName = loggerName;
	}

	internal MapBuilderBase()
	{
		ExceptionEnabled = true;
	}

	public MapBuilderBase SetDataSource(DataTable table)
	{
		Table = table;
		return this;
	}

	public abstract MapDataSetList Map();

	public abstract Type BuilderType();

	internal abstract RulesBuilderBase CreateRulesBuilder();

	internal abstract object MapObject(DataRow row, ImportSettings settings, Relation relation);

	protected internal ImportSettings MapAll(IList<MapInfo> mapInfoList)
	{
		return MapAll(mapInfoList, null);
	}

	protected internal abstract ImportSettings MapAll(IList<MapInfo> mapInfoList, ImportSettings settings);
}
