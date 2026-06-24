using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Providers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping;

public class MapBuilder : MapBuilderBase
{
	protected Action<ActionInfo> action;

	protected Guid loggerKey = Guid.NewGuid();

	private List<MapBuilderBase> importObjectBuilders = new List<MapBuilderBase>();

	protected bool loggerDisabled;

	protected Action<MapActionInfo> rowAction;

	protected Action<RulesBuilder> rulesAction;

	protected Type objectType;

	private static IEnumerable<IMapProvider> mapProviders;

	public static MapBuilder Create(DataTable table, Type objectType)
	{
		return new MapBuilder(table, objectType);
	}

	public MapBuilder()
	{
		AutoMap(value: true);
	}

	public MapBuilder(DataTable table)
		: this()
	{
		if (table != null)
		{
			SetDataSource(table);
		}
	}

	public MapBuilder(DataTable table, Type objectType)
		: this(table)
	{
		this.objectType = InterfaceActivator.TypeOf(objectType);
	}

	public MapBuilder Exception(bool value)
	{
		base.ExceptionEnabled = value;
		return this;
	}

	public MapBuilder LoggerDisable(bool value)
	{
		loggerDisabled = value;
		return this;
	}

	public MapBuilder Action(Action<ActionInfo> value)
	{
		action = value;
		return this;
	}

	public MapBuilder AutoMap(bool value)
	{
		base.AutoMapProperties = value;
		return this;
	}

	public MapBuilder Rules(Action<RulesBuilder> rulesAction)
	{
		this.rulesAction = rulesAction;
		return this;
	}

	internal MapBuilder Logger(SmartLogger logger)
	{
		BuilderLogger = logger;
		return this;
	}

	internal override RulesBuilderBase CreateRulesBuilder()
	{
		return new RulesBuilder(base.Table, objectType);
	}

	public MapBuilder RowAction(Action<MapActionInfo> action)
	{
		rowAction = action;
		return this;
	}

	public override Type BuilderType()
	{
		return objectType;
	}

	public override MapDataSetList Map()
	{
		return Map(null);
	}

	public MapDataSetList Map(Action<MapActionInfo> action)
	{
		loggerKey = ((BuilderLogger == null) ? loggerKey : BuilderLogger.Key);
		rowAction = action;
		List<MapInfo> mapInfoList = new List<MapInfo>();
		ImportSettings settings = MapAll(mapInfoList);
		foreach (MapBuilderBase importObjectBuilder in importObjectBuilders)
		{
			importObjectBuilder.SetDataSource(base.Table);
			settings = importObjectBuilder.MapAll(mapInfoList, settings);
		}
		return new MapDataSetList(mapInfoList);
	}

	protected internal override ImportSettings MapAll(IList<MapInfo> mapInfoList, ImportSettings settings)
	{
		string text = "Mapping";
		using SmartLogger smartLogger = ((BuilderLogger != null) ? BuilderLogger.InnerLogger(loggerDisabled, text) : new BulkDataImportLogger(loggerDisabled, LoggerName, text, string.Empty, loggerKey));
		IList<DataRow> list = ((base.Table != null) ? base.Table.Rows.CastToArrayOrNull<DataRow>() : new DataRow[0]);
		int num = 0;
		smartLogger.InfoIfEnabled($"Object (ObjectType: {objectType}, Rows: {list.Count})");
		settings = settings ?? new ImportSettings(smartLogger, base.ExceptionEnabled, loggerDisabled, mapInfoList);
		foreach (DataRow item in list)
		{
			smartLogger.InfoIfEnabled("Row: " + num);
			MapObject(item, settings, null);
			if (rowAction != null)
			{
				using SmartLogger logger = smartLogger.InnerLogger(loggerDisabled, "Finish action");
				rowAction(new MapActionInfo(mapInfoList, logger, num));
			}
			num++;
		}
		return settings;
	}

	internal override object MapObject(DataRow row, ImportSettings settings, Relation relation)
	{
		IMapProvider mapProvider = MapProviders().FirstOrDefault((IMapProvider p) => p.Can(objectType));
		if (mapProvider == null)
		{
			settings.Logger.Info(SR.T("Не найден провайдер маппинга для типа {0}", objectType));
			return null;
		}
		return mapProvider.Map(objectType, this, row, delegate(RulesBuilderBase rulesBuilder)
		{
			if (rulesAction != null)
			{
				rulesAction((RulesBuilder)rulesBuilder);
			}
		}, settings, relation, action);
	}

	public MapBuilder AddObject(Type t)
	{
		MapBuilder mapBuilder = Create(null, t);
		InitAddObject(mapBuilder);
		return mapBuilder;
	}

	protected virtual void InitAddObject(MapBuilder builder)
	{
		builder.BuilderLogger = BuilderLogger;
		builder.ExceptionEnabled = base.ExceptionEnabled;
		builder.LoggerDisable(loggerDisabled);
		importObjectBuilders.Add(builder);
	}

	private static IEnumerable<IMapProvider> MapProviders()
	{
		if (mapProviders == null)
		{
			mapProviders = ComponentManager.Current.GetExtensionPoints<IMapProvider>();
		}
		return mapProviders;
	}
}
public class MapBuilder<T> : MapBuilder where T : class
{
	public static MapBuilder<T> Create()
	{
		return new MapBuilder<T>();
	}

	public static MapBuilder<T> Create(DataTable table)
	{
		return new MapBuilder<T>(table).AutoMap(value: true);
	}

	public MapBuilder()
		: base(null, typeof(T))
	{
	}

	public MapBuilder(DataTable table)
		: base(table, typeof(T))
	{
	}

	public new MapBuilder<T> Exception(bool value)
	{
		base.Exception(value);
		return this;
	}

	public new MapBuilder<T> LoggerDisable(bool value)
	{
		base.LoggerDisable(value);
		return this;
	}

	public new MapBuilder<T> Action(Action<ActionInfo> value)
	{
		base.Action(value);
		return this;
	}

	public new MapBuilder<T> AutoMap(bool value)
	{
		base.AutoMap(value);
		return this;
	}

	public MapBuilder<T> Rules(Action<RulesBuilder<T>> rulesAction)
	{
		Action<RulesBuilder> action = (base.rulesAction = delegate(RulesBuilder rulesBuilder)
		{
			if (rulesAction != null)
			{
				rulesAction((RulesBuilder<T>)rulesBuilder);
			}
		});
		return this;
	}

	internal new MapBuilder<T> Logger(SmartLogger logger)
	{
		base.Logger(logger);
		return this;
	}

	internal override RulesBuilderBase CreateRulesBuilder()
	{
		return new RulesBuilder<T>(base.Table);
	}

	public new MapBuilder<T> RowAction(Action<MapActionInfo> action)
	{
		base.RowAction(action);
		return this;
	}

	public MapBuilder<T1> AddObject<T1>() where T1 : class
	{
		MapBuilder<T1> mapBuilder = MapBuilder<T1>.Create();
		InitAddObject(mapBuilder);
		return mapBuilder;
	}

	public override Type BuilderType()
	{
		return typeof(T);
	}
}
