using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers;

public abstract class ObjectMapProviderBase : IMapProvider
{
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IEnumerable<IMapPropertyExtension> PropertyExtension { get; set; }

	protected abstract string DefaultPropertyKey { get; }

	public abstract bool Can(Type objectType);

	protected virtual List<string> AdditionalProperties(Type type)
	{
		return new List<string>();
	}

	protected virtual List<string> AdditionalProperties(ClassMetadata classMetadata)
	{
		return new List<string>();
	}

	protected virtual MapPropertyInfo CreateAdditionalProperty(Type objectType, string propertyName)
	{
		return null;
	}

	protected virtual MapObject CreateObject(Type objectType)
	{
		return new MapObject(objectType);
	}

	protected virtual MapObject ConvertObjectLink(MapObject @object, Dictionary<string, object> propertyList)
	{
		return @object;
	}

	protected virtual object CreateAdditionalPropertyValue(Type objectType, object targetObject, string propertyName)
	{
		return null;
	}

	public virtual object Map(Type objectType, MapBuilderBase builder, DataRow row, Action<RulesBuilderBase> rulesAction, ImportSettings settings, Relation relation, Action<ActionInfo> action)
	{
		MapObject mapObject = CreateObject(objectType);
		using SmartLogger smartLogger = settings.Logger.InnerLogger($"Object (ObjectType: {objectType})");
		List<string> keyList = new List<string>();
		Dictionary<string, object> propertyList = new Dictionary<string, object>();
		ImportSettings mapSettings = settings.CreateNew(smartLogger);
		RulesBuilderBase mapRulesBuilder = builder.CreateRulesBuilder();
		rulesAction?.Invoke(mapRulesBuilder);
		ClassMetadata classMetadata = (ClassMetadata)InterfaceActivator.LoadMetadata(objectType);
		List<string> list = AdditionalProperties(objectType);
		list.AddRange(AdditionalProperties(classMetadata));
		list.AddRange(classMetadata.Properties.Select((PropertyMetadata p) => p.Name));
		List<string> source = list.Distinct().ToList();
		keyList.AddRange(source.Where((string property) => mapRulesBuilder.IsKey(property)));
		if (!keyList.Any() && !string.IsNullOrEmpty(DefaultPropertyKey) && list.Any((string p) => p == DefaultPropertyKey))
		{
			keyList.Add(DefaultPropertyKey);
		}
		List<string> properties = source.Where((string property) => keyList.All((string key) => key != property)).ToList();
		GetValuesForProperties(builder.AutoMapProperties, row, mapObject, mapRulesBuilder, smartLogger, mapSettings, keyList, propertyList);
		AddToStorage(mapSettings, propertyList, mapObject);
		GetValuesForProperties(builder.AutoMapProperties, row, mapObject, mapRulesBuilder, smartLogger, mapSettings, properties, propertyList);
		keyList.RemoveAll((string key) => !propertyList.ContainsKey(key));
		if (IsEmptyObject(mapObject, propertyList))
		{
			return null;
		}
		if (relation != null && relation.RelationType == RelationType.OneToMany)
		{
			AddPropertyValue(smartLogger, relation.KeyProperty, relation.TargetObject, propertyList);
		}
		MapInfo mapInfo = settings.MapInfos.FirstOrDefault((MapInfo m) => m.IsEquals(objectType, propertyList.Keys.ToList(), keyList));
		if (mapInfo == null)
		{
			mapInfo = new MapInfo(objectType, MetadataRuntimeService);
			settings.MapInfos.Add(mapInfo);
		}
		ImportObject @object = MapProperties(mapInfo, objectType, keyList, propertyList, mapSettings);
		action?.Invoke(new ActionInfo(@object, smartLogger));
		return ConvertObjectLink(mapObject, propertyList);
	}

	private ImportObject MapProperties(MapInfo mapInfo, Type objectType, List<string> keys, Dictionary<string, object> properties, ImportSettings mapSettings)
	{
		IList<MapPropertyInfo> properties2 = mapInfo.Properties;
		ImportObject importObject = new ImportObject(objectType);
		IMetadata metadata = InterfaceActivator.LoadMetadata(objectType);
		IMapTypeExtension mapTypeExtension = ComponentManager.Current.GetExtensionPoints<IMapTypeExtension>().FirstOrDefault((IMapTypeExtension p) => p.Can(metadata));
		foreach (string propertyName in properties.Keys)
		{
			MapPropertyInfo mapPropertyInfo = mapInfo.FindProperty(propertyName);
			if (mapPropertyInfo == null)
			{
				PropertyMetadata propertyInfo = InterfaceActivator.LoadPropertyMetadata(objectType, propertyName, inherit: true);
				if (propertyInfo == null)
				{
					if (!AdditionalProperties(objectType).Contains(propertyName))
					{
						continue;
					}
					mapPropertyInfo = CreateAdditionalProperty(objectType, propertyName);
					if (mapPropertyInfo == null)
					{
						continue;
					}
				}
				else
				{
					IMetadata metadata2 = InterfaceActivator.LoadMetadata(propertyInfo.DeclaringType);
					string tableName = ((mapTypeExtension != null) ? mapTypeExtension.TableName(metadata2) : objectType.Name);
					IMapPropertyExtension mapPropertyExtension = PropertyExtension.FirstOrDefault((IMapPropertyExtension p) => p.Can(propertyInfo));
					if (mapPropertyExtension == null)
					{
						continue;
					}
					bool isKey = keys.Any((string k) => k == propertyName);
					mapPropertyInfo = mapPropertyExtension.CreatePropertyInfo(propertyInfo, tableName, isKey);
					mapInfo.Properties.Add(mapPropertyInfo);
				}
			}
			PropertyValue orCreateProperty = importObject.GetOrCreateProperty(mapPropertyInfo);
			mapPropertyInfo.PropertyExtension.SetValue(orCreateProperty, ConvertDbValue(properties[propertyName]), new SetPropertyInfo(mapSettings));
			if (!properties2.Contains(mapPropertyInfo))
			{
				properties2.Add(mapPropertyInfo);
			}
		}
		ImportObject importObject2 = mapInfo.Objects.FirstOrDefault((ImportObject o) => o.IsEqualsForKey(importObject));
		if (importObject2 != null)
		{
			importObject2.MergeProperties(importObject);
			return importObject2;
		}
		mapInfo.Objects.Add(importObject);
		return importObject;
	}

	private bool IsEmptyObject(MapObject targetObject, Dictionary<string, object> propertyList)
	{
		List<string> additionalProperties = AdditionalProperties(targetObject.ObjectType);
		bool result = true;
		foreach (string item in propertyList.Keys.Where((string p) => additionalProperties.All((string addProp) => addProp != p)))
		{
			object obj = propertyList[item];
			if (obj != null && obj != DBNull.Value)
			{
				if (obj is ObjectId)
				{
					return false;
				}
				if ((!(obj is IEnumerable<object> source) || source.Count() != 0) && (!(obj is MapObject mapObject) || !mapObject.IsEmpty()))
				{
					return false;
				}
			}
		}
		return result;
	}

	private void AddPropertyValue(SmartLogger logger, string property, object value, Dictionary<string, object> propertyList)
	{
		logger.InfoIfEnabled("Property: " + property);
		propertyList[property] = value;
	}

	private void GetValuesForProperties(bool autoMapProperties, DataRow row, MapObject targetObject, RulesBuilderBase mapRulesBuilder, SmartLogger rowLogger, ImportSettings mapSettings, List<string> properties, Dictionary<string, object> propertyList)
	{
		foreach (string property in properties)
		{
			if (mapRulesBuilder.IsIgnore(property))
			{
				continue;
			}
			if (!mapRulesBuilder.CanMap(property))
			{
				if (autoMapProperties && row.Table.Columns.Contains(property))
				{
					object value = row[property];
					AddPropertyValue(rowLogger, property, value, propertyList);
				}
				if (!AdditionalProperties(targetObject.ObjectType).Contains(property))
				{
					continue;
				}
			}
			object value2 = (AdditionalProperties(targetObject.ObjectType).Contains(property) ? CreateAdditionalPropertyValue(targetObject.ObjectType, targetObject, property) : MapRules(mapRulesBuilder, targetObject, property, row, mapSettings.CreateNew(rowLogger)));
			AddPropertyValue(rowLogger, property, value2, propertyList);
		}
	}

	private void AddToStorage(ImportSettings mapSettings, Dictionary<string, object> keysList, MapObject targetObject)
	{
		MapObject mapObject = mapSettings.FindObject(targetObject.ObjectType, keysList);
		if (mapObject != null)
		{
			targetObject.SetDelegate(mapObject);
		}
		else
		{
			mapSettings.AddNewObject(targetObject, keysList);
		}
	}

	private object ConvertDbValue(object value)
	{
		if (value != DBNull.Value)
		{
			return value;
		}
		return null;
	}

	private object MapRules(RulesBuilderBase mapRulesBuilder, MapObject targetObject, string propertyName, DataRow row, ImportSettings mapSettings)
	{
		Type objectType = targetObject.ObjectType;
		object obj = null;
		if (mapRulesBuilder.CanMap(propertyName, extension: false))
		{
			if (mapRulesBuilder.ImportBuilders.ContainsKey(propertyName))
			{
				using SmartLogger smartLogger = mapSettings.Logger.InnerLogger(mapSettings.Logger.ToString() + " ... Object property", "Property: " + propertyName);
				ImportSettings importSettings = mapSettings.CreateNew(smartLogger);
				try
				{
					Relation relation = null;
					if (mapRulesBuilder.RelationProperties != null && mapRulesBuilder.RelationProperties.ContainsKey(propertyName))
					{
						relation = mapRulesBuilder.RelationProperties[propertyName];
						relation.TargetObject = ConvertObjectLink(targetObject, null);
					}
					obj = (mapRulesBuilder.IsCollecttion(propertyName) ? MapCollection(mapRulesBuilder, propertyName, row, importSettings, (int? idx, int count, SmartLogger logger) => mapRulesBuilder.ImportBuilders[propertyName].MapObject(row, mapSettings.CreateNew(logger, idx, count), relation)) : mapRulesBuilder.ImportBuilders[propertyName].MapObject(row, mapSettings.CreateNew(smartLogger), null));
					if (relation != null)
					{
						if (relation.RelationType == RelationType.ManyToMany)
						{
							List<MapObject> list = ((IList<object>)obj).Cast<MapObject>().ToList();
							if (list != null)
							{
								obj = new MapRelationManyToMany(relation, list);
								return obj;
							}
							return obj;
						}
						return obj;
					}
					return obj;
				}
				catch (Exception exception)
				{
					smartLogger.Error(exception);
					if (importSettings.ExceptionEnabled)
					{
						throw;
					}
					return obj;
				}
			}
			obj = (mapRulesBuilder.IsCollecttion(propertyName) ? MapCollection(mapRulesBuilder, propertyName, row, mapSettings, (int? idx, int count, SmartLogger logger) => MapObject(mapRulesBuilder, targetObject, objectType, propertyName, row, mapSettings.CreateNew(logger, idx, count))) : MapObject(mapRulesBuilder, targetObject, objectType, propertyName, row, mapSettings));
		}
		else
		{
			RulesBuilderBase rulesBuilderBase = mapRulesBuilder.RulesExtensions.FirstOrDefault((RulesBuilderBase r) => r.CanMap(propertyName));
			if (rulesBuilderBase != null)
			{
				obj = MapRules(rulesBuilderBase, targetObject, propertyName, row, mapSettings);
			}
		}
		return obj;
	}

	private IEnumerable MapCollection(RulesBuilderBase mapRulesBuilder, string propertyName, DataRow row, ImportSettings mapSettings, Func<int?, int, SmartLogger, object> action)
	{
		if (!mapRulesBuilder.IsCollecttion(propertyName) || action == null)
		{
			return null;
		}
		IEnumerable enumerable = null;
		PropertyCollectionSettings propertyCollectionSettings = new PropertyCollectionSettings(row, mapSettings.Logger);
		int num = mapRulesBuilder.PropertySettingsDictionary[propertyName](propertyCollectionSettings);
		if (propertyCollectionSettings.CollectionHandler)
		{
			object result;
			if (num <= 0)
			{
				IEnumerable enumerable2 = new List<object>();
				result = enumerable2;
			}
			else
			{
				result = (IEnumerable)action(null, num, propertyCollectionSettings.Logger);
			}
			return (IEnumerable)result;
		}
		List<object> list = new List<object>();
		if (num > 0)
		{
			using SmartLogger smartLogger = mapSettings.Logger.InnerLogger(mapSettings.LoggerDisabled, "Collection", "Count: " + num);
			for (int i = 0; i < num; i++)
			{
				using SmartLogger arg = smartLogger.InnerLogger(mapSettings.LoggerDisabled, "Index " + i);
				object obj = action(i, num, arg);
				if (obj != null && obj != DBNull.Value)
				{
					list.Add(obj);
				}
			}
		}
		return list;
	}

	private object MapObject(RulesBuilderBase mapRulesBuilder, MapObject targetObject, Type objectType, string propertyName, DataRow row, ImportSettings mapSettings)
	{
		ActionBuilderBase actionBuilderBase = mapRulesBuilder.ActionBuilders[propertyName];
		if (actionBuilderBase.IsIgnore())
		{
			return null;
		}
		return MapActionObject(actionBuilderBase, targetObject, objectType, row, mapSettings);
	}

	private object MapActionObject(ActionBuilderBase actionBuilder, MapObject targetObject, Type objectType, DataRow row, ImportSettings mapSettings)
	{
		object result = null;
		if (!actionBuilder.ActionExist())
		{
			string text = (string.IsNullOrEmpty(actionBuilder.ColumnName) ? actionBuilder.PropertyName : actionBuilder.ColumnName);
			if (row.Table.Columns.Contains(text))
			{
				result = row[text];
			}
			return result;
		}
		using SmartLogger smartLogger = mapSettings.Logger.InnerLogger(mapSettings.Logger.ToString() + " ... Action", "Property: " + actionBuilder.PropertyName);
		ImportSettings importSettings = mapSettings.CreateNew(smartLogger);
		try
		{
			result = actionBuilder.Action(targetObject, row, smartLogger, importSettings.Index, importSettings.Count);
			return result;
		}
		catch (Exception exception)
		{
			smartLogger.Error(exception);
			if (importSettings.ExceptionEnabled)
			{
				throw;
			}
			return result;
		}
	}
}
